#if UNITY_EDITOR

using System;
using System.Collections.Generic;
using System.IO;
using Cysharp.Threading.Tasks;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

namespace GBMDK.Editor
{
    public class ShaderViewer : ScriptableSingleton<ShaderViewer>
    {
        [FormerlySerializedAs("CachedShaders")]
        public List<Shader> cachedShaders = new();

        private readonly List<Material> _cachedMaterials = new();

        private static string CatalogPath => Path.Combine(GBMDKConfigSettings.instance.gameSettings.gameFolderPath,
            "Gang Beasts_Data", "StreamingAssets", "aa", "catalog.json");

        public void OnDisable()
        {
            var materials = _cachedMaterials.ToArray();
            foreach (var m in materials)
            {
                if (m == null || m.shader == null) continue;

                m.shader = Shader.Find(m.shader.name);
                _cachedMaterials.Remove(m);
                EditorUtility.SetDirty(m);
            }

            AssetBundle.UnloadAllAssetBundles(false);
        }

        private static void OnChangedEvent(Material _)
        {
            Activate();
        }

        [InitializeOnLoadMethod]
        public static void Initialize()
        {
            EditorSceneManager.sceneSaving += EditorSceneManagerOnsceneSaving;
            EditorSceneManager.sceneSaved += EditorSceneManagerOnsceneSaved;
            EditorApplication.playModeStateChanged += EditorApplicationOnplayModeStateChanged;
            EditorApplication.hierarchyChanged += Activate;
            MaterialEditorListener.ShaderChangedEvent += OnChangedEvent;
            EditorApplication.update += OnUpdate;
            Selection.selectionChanged += Activate;
            Activate();
        }

        private static void EditorApplicationOnplayModeStateChanged(PlayModeStateChange obj)
        {
            switch (obj)
            {
                case PlayModeStateChange.EnteredPlayMode or PlayModeStateChange.EnteredEditMode:
                    Activate();
                    break;
                case PlayModeStateChange.ExitingPlayMode or PlayModeStateChange.ExitingEditMode:
                    instance.OnDisable();
                    break;
            }
        }

        private static void EditorSceneManagerOnsceneSaved(Scene scene)
        {
            Activate();
        }

        private static void EditorSceneManagerOnsceneSaving(Scene scene, string path)
        {
            instance.OnDisable();
        }

        private static void OnUpdate()
        {
            EditorApplication.QueuePlayerLoopUpdate();
        }

        [MenuItem("GBMDK/Debug/Activate Shader Viewer")]
        public static async void Activate()
        {
            try
            {
                await instance.OnAsyncLoop();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private async UniTask OnAsyncLoop()
        {
            await instance.DoApplyingAddressableShaders();
        }

        private static Material[] RetrieveMaterials()
        {
            var allMats = Resources.FindObjectsOfTypeAll<Material>();
            return allMats;
        }

        private async UniTask<Shader[]> RetrieveAddressableShaders(IResourceLocator catalog)
        {
            //if (CachedShaders.Count > 0) return CachedShaders.ToArray();
            var ret = new List<Shader>();
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
                        shaderAsset.hideFlags = HideFlags.DontSave;
                        ret.Add(shaderAsset);
                        //Debug.Log($"Loaded shader of name \"{shaderAsset.name}\"");
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }

            cachedShaders = new List<Shader>(ret.ToArray());
            return ret.ToArray();
        }

        private async UniTask DoApplyingAddressableShaders()
        {
            AssetBundle.UnloadAllAssetBundles(false);

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

        private async UniTask<IResourceLocator> LoadTempCatalog()
        {
            if (!File.Exists(CatalogPath)) throw new FileNotFoundException(CatalogPath);
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