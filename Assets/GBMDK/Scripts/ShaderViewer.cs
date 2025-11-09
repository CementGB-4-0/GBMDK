#if UNITY_EDITOR

using System.Collections.Generic;
using System.IO;
using Cysharp.Threading.Tasks;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace GBMDK.Editor
{
    public class ShaderViewer : ScriptableSingleton<ShaderViewer>
    {
        public static List<Shader> CachedShaders = new();
        private static readonly List<Material> _cachedMaterials = new();

        private static string CatalogPath => Path.Combine(GBMDKConfigSettings.instance.gameSettings.gameFolderPath,
            "Gang Beasts_Data", "StreamingAssets", "aa", "catalog.json");

        private void Awake()
        {
            CachedShaders.Clear();
            _cachedMaterials.Clear();
            EditorSceneManager.sceneSaved += OnEditorSceneManagerOnsceneSaved;
            MaterialEditorListener.ShaderChangedEvent += OnChangedEvent;
            EditorApplication.update += OnUpdate;
        }

        public void OnDisable()
        {
            EditorSceneManager.sceneSaved -= OnEditorSceneManagerOnsceneSaved;
            MaterialEditorListener.ShaderChangedEvent -= OnChangedEvent;
            EditorApplication.update -= OnUpdate;
            foreach (var cachedShader in CachedShaders.ToArray())
            {
                CachedShaders.Remove(cachedShader);
                DestroyImmediate(cachedShader);
            }

            CachedShaders.Clear();

            var materials = _cachedMaterials.ToArray();
            foreach (var m in materials)
            {
                if (m == null || m.shader == null) continue;

                m.shader = Shader.Find(m.shader.name);
                _cachedMaterials.Remove(m);
            }
        }

        private void OnEditorSceneManagerOnsceneSaved(Scene _)
        {
            OnShaderChangedEvent();
        }

        private void OnChangedEvent(Material _)
        {
            OnShaderChangedEvent();
        }

        [InitializeOnLoadMethod]
        [MenuItem("GBMDK/Debug/Reset Shader Viewer")]
        public static void Initialize()
        {
            instance.OnDisable();
            instance.Awake();
            OnShaderChangedEvent();
        }

        private void OnUpdate()
        {
            EditorApplication.QueuePlayerLoopUpdate();
        }

        private static void OnShaderChangedEvent()
        {
            OnAsyncLoop().Forget();
        }

        private static async UniTask OnAsyncLoop()
        {
            await DoApplyingAddressableShaders();
        }

        private static Material[] RetrieveMaterials()
        {
            var allMats = Resources.FindObjectsOfTypeAll<Material>();
            return allMats;
        }

        private static async UniTask<Shader[]> RetrieveAddressableShaders(IResourceLocator catalog)
        {
            //if (CachedShaders.Count > 0) return CachedShaders.ToArray();

            var ret = new List<Shader>();
            AssetBundle.UnloadAllAssetBundles(false);
            foreach (var key in catalog.Keys)
            {
                catalog.Locate(key, typeof(Object), out var list);
                if (list == null) continue;
                foreach (var obj in list)
                {
                    try
                    {
                        if (obj.ResourceType != typeof(Shader)) continue;
                        var shaderAsset = await Addressables.LoadAssetAsync<Shader>(obj);
                        shaderAsset.hideFlags = HideFlags.HideAndDontSave;
                        ret.Add(shaderAsset);
                        Debug.Log($"Loaded shader of name \"{shaderAsset.name}\"");
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }

            CachedShaders = new List<Shader>(ret.ToArray());
            return ret.ToArray();
        }

        private static async UniTask DoApplyingAddressableShaders()
        {
            var catalog = await LoadTempCatalog();
            var shaders = await RetrieveAddressableShaders(catalog);
            var dummyMaterials = RetrieveMaterials();

            foreach (var dm in dummyMaterials)
            {
                Shader chosenShader = null;
                foreach (var sh in shaders)
                    if (sh.name == dm.shader.name)
                    {
                        chosenShader = sh;
                        break;
                    }

                if (chosenShader == null) continue;
                dm.shader = chosenShader;
                if (_cachedMaterials.Contains(dm)) continue;
                _cachedMaterials.Add(dm);
            }

            DisposeTempCatalog(catalog);
        }

        private static async UniTask<IResourceLocator> LoadTempCatalog()
        {
            var catalogText = await File.ReadAllTextAsync(CatalogPath);
            var catalogDirPath = Path.GetDirectoryName(CatalogPath)?.Replace(@"\", @"\\");
            catalogText = catalogText.Replace("{UnityEngine.AddressableAssets.Addressables.RuntimePath}",
                    catalogDirPath)
                .Replace("{MelonLoader.Utils.MelonEnvironment.ModsDirectory}", catalogDirPath);
            var tempCatalog = Path.GetTempFileName();
            await File.WriteAllTextAsync(tempCatalog, catalogText);
            var catalog = await Addressables.LoadContentCatalogAsync(tempCatalog, true);
            Addressables.AddResourceLocator(catalog);
            return catalog;
        }

        private static void DisposeTempCatalog(IResourceLocator catalog)
        {
            Addressables.RemoveResourceLocator(catalog);
        }
    }
}

#endif