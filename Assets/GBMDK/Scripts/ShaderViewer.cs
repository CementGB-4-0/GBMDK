using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;
using GBMDK.Editor;
using NaughtyAttributes;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using Object = UnityEngine.Object;

namespace GBMDK
{
    [ExecuteAlways]
    public class ShaderViewer : MonoBehaviour
    {
        private static List<Shader> _cachedShaders = new();
        private CancellationTokenSource cts = new();

        private readonly Dictionary<Material, string> dummyShaderNames = new();

        private static string CatalogPath => Path.Combine(GBMDKConfigSettings.instance.gameSettings.gameFolderPath,
            "Gang Beasts_Data", "StreamingAssets", "aa", "catalog.json");

        private void OnEnable()
        {
            cts?.Cancel();
            cts = new CancellationTokenSource();
            Selection.selectionChanged += Bind_OnSelectionChange;
        }

        private void OnDisable()
        {
            Selection.selectionChanged -= Bind_OnSelectionChange;
            foreach (var dm in dummyShaderNames)
            {
                if (dm.Key == null) continue;
                dm.Key.shader = Shader.Find(dm.Value);
            }
        }

        [Button]
        private void ClearShaderCache()
        {
            _cachedShaders = new List<Shader>();
            Bind_OnSelectionChange();
        }

        private void Bind_OnSelectionChange()
        {
            OnSelectionChange().Forget();
        }

        private async UniTaskVoid OnSelectionChange()
        {
            if (Selection.activeTransform != null)
            {
                if (Selection.activeTransform == transform || Selection.activeTransform.parent == transform)
                {
                    await OnActivated(Selection.gameObjects);
                    return;
                }

                var doActivate = false;
                var children = new List<GameObject>();
                foreach (Transform child in Selection.activeTransform)
                {
                    children.Add(child.gameObject);
                    if (child == transform) doActivate = true;
                }

                if (doActivate)
                {
                    await OnActivated(children.ToArray());
                    return;
                }
            }

            foreach (var dm in dummyShaderNames)
            {
                if (dm.Key == null) continue;
                dm.Key.shader = Shader.Find(dm.Value);
            }

            cts?.Cancel();
            cts = new CancellationTokenSource();
        }

        private async UniTask OnActivated(GameObject[] obj)
        {
            if (obj is not { Length: > 0 })
            {
                cts?.Cancel();
                return;
            }

            await DoApplyingAddressableShaders(obj);
        }

        private static Material[] RetrieveDummyMaterials(MeshRenderer[] targets)
        {
            var ret = targets.SelectMany(rend => rend.sharedMaterials).ToArray();
            return ret;
        }

        private async UniTask<Shader[]> RetrieveAddressableShaders(IResourceLocator catalog)
        {
            if (_cachedShaders.Count > 0) return _cachedShaders.ToArray();

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
                        var shaderAsset = await Addressables.LoadAssetAsync<Shader>(obj)
                            .WithCancellation(cts.Token, false, true);
                        ret.Add(shaderAsset);
                        Debug.Log($"Loaded shader of name \"{shaderAsset.name}\"");
                    }
                    catch
                    {
                        // ignored
                    }

                    EditorApplication.QueuePlayerLoopUpdate();
                }
            }

            _cachedShaders = new List<Shader>(ret.ToArray());
            return ret.ToArray();
        }

        private async UniTask DoApplyingAddressableShaders(GameObject[] targets)
        {
            var catalogText = await File.ReadAllTextAsync(CatalogPath, cts.Token);
            var catalogDirPath = Path.GetDirectoryName(CatalogPath)?.Replace(@"\", @"\\");
            catalogText = catalogText.Replace("{UnityEngine.AddressableAssets.Addressables.RuntimePath}",
                    catalogDirPath)
                .Replace("{MelonLoader.Utils.MelonEnvironment.ModsDirectory}", catalogDirPath);
            var tempCatalog = Path.GetTempFileName();
            await File.WriteAllTextAsync(tempCatalog, catalogText, cts.Token);
            var catalog = await Addressables.LoadContentCatalogAsync(tempCatalog, true)
                .WithCancellation(cts.Token, false, true);
            Addressables.AddResourceLocator(catalog);
            var shaders = await RetrieveAddressableShaders(catalog);

            foreach (var target in targets)
            {
                if (!target.TryGetComponent<MeshRenderer>(out _) &&
                    target.GetComponentInChildren<MeshRenderer>() == null) return;
                var dummyMaterials = RetrieveDummyMaterials(target.GetComponentsInChildren<MeshRenderer>());
                foreach (var dm in dummyMaterials)
                {
                    dummyShaderNames[dm] = dm.shader.name;
                    Shader chosenShader = null;
                    foreach (var sh in shaders)
                        if (sh.name == dm.shader.name)
                        {
                            chosenShader = sh;
                            break;
                        }

                    if (chosenShader == null) continue;
                    dm.shader = chosenShader;
                    EditorUtility.SetDirty(dm);
                }
            }

            Addressables.RemoveResourceLocator(catalog);
        }
    }
}