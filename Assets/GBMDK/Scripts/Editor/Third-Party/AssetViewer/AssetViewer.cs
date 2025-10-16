using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GBMDK.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using Object = UnityEngine.Object;

/**
 * TreeNode.cs
 * Author: Luke Holland (http://lukeholland.me/)
 */

namespace TreeView
{
    public class AssetViewer : EditorWindow
    {
        private readonly List<IResourceLocation> assetKeys = new();

        private readonly List<(IResourceLocation, Type, string)> localCache = new();

        private AssetTree assetTree;
        private AssetTreeIMGUI assetTreeGUI;

        private string catalogError = "None :)";
        private AsyncOperationHandle<IResourceLocator> catalogHandle;
        private string catalogPath = "";

        private bool isCatalogLoadSucessfull = true;
        private bool isLoadingCatalog;
        private Object loadedAsset;
        private Vector2 scrollPosition;
        private string searchString;
        private string tempCatalog = "";

        private string defaultCatalogPath => Path.Combine(GBMDKConfigSettings.instance.gameSettings.gameFolderPath,
            "Gang Beasts_Data", "StreamingAssets", "aa", "catalog.json");

        protected void OnEnable()
        {
            // setup
            assetTree = new AssetTree();
            assetTreeGUI = new AssetTreeIMGUI(assetTree.Root);

            catalogPath = defaultCatalogPath;

            // fill tree with example data
            searchString = "";
            Search(searchString);
        }

        private void OnDestroy()
        {
            if (catalogHandle.IsValid()) Addressables.Release(catalogHandle);
        }

        protected void OnGUI()
        {
            GUILayout.Space(10f);

            GUILayout.Label("Select Catalog file:");

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Browse", GUILayout.Width(80f)))
            {
                var newCatalogPath = EditorUtility.OpenFilePanel("Select catalog file", catalogPath, "json");
                if (!string.IsNullOrWhiteSpace(newCatalogPath))
                    catalogPath = newCatalogPath;
            }

            GUILayout.Label(catalogPath);

            GUILayout.EndHorizontal();

            GUILayout.Space(10f);

            GUILayout.BeginHorizontal();

            if (!isLoadingCatalog && GUILayout.Button("Refresh Asset List"))
            {
                UnloadAllStuff();
                LoadContentCatalog();
            }

            if (GUILayout.Button("Unload All Asset Bundles")) UnloadAllStuff();

            GUILayout.EndHorizontal();

            GUILayout.Space(10f);

            // draw search
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);

            EditorGUILayout.LabelField("Search:", EditorStyles.miniLabel, GUILayout.Width(40));

            EditorGUI.BeginChangeCheck();
            searchString =
                EditorGUILayout.TextField(searchString, EditorStyles.toolbarTextField, GUILayout.ExpandWidth(true));
            if (EditorGUI.EndChangeCheck()) Search(searchString);

            EditorGUILayout.EndHorizontal();

            switch (assetKeys.Count)
            {
                case 0 when !isLoadingCatalog && isCatalogLoadSucessfull:
                    GUILayout.Label("No catalog loaded or empty catalog :/", EditorStyles.boldLabel);
                    break;
                case 0 when !isLoadingCatalog && !isCatalogLoadSucessfull:
                    GUILayout.Label("Failed to load the catalog: " + catalogError, EditorStyles.boldLabel);
                    break;
                case 0 when isLoadingCatalog:
                    GUILayout.Label("Loading catalog 👍", EditorStyles.boldLabel);
                    break;
                default:
                    // draw tree
                    scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
                    assetTreeGUI.DrawTreeLayout();
                    EditorGUILayout.EndScrollView();
                    break;
            }
        }

        private void OnInspectorUpdate()
        {
            Repaint();
        }

        [MenuItem("Tools/GBMDK/Asset Viewer")]
        private static void CreateEditorWindow()
        {
            GetWindow<AssetViewer>("Asset Viewer");
        }

        private void UnloadAllStuff()
        {
            assetTree.Clear();
            localCache.Clear();
            AssetBundle.UnloadAllAssetBundles(false);
        }

        private void Search(string query)
        {
            assetTree.Clear();

            var smolQuery = query.ToLower();

            foreach (var asset in localCache)
            {
                if (!asset.Item3.ToLower().Contains(smolQuery) && !asset.Item2.ToString().ToLower().Contains(smolQuery))
                    continue;

                assetTree.AddAsset(asset.Item1, asset.Item3);
            }
        }

        private void LoadContentCatalog()
        {
            isLoadingCatalog = true;
            var catalogText = File.ReadAllText(catalogPath);
            var catalogDirPath = Path.GetDirectoryName(catalogPath)?.Replace(@"\", @"\\");
            catalogText = catalogText.Replace("{UnityEngine.AddressableAssets.Addressables.RuntimePath}",
                    catalogDirPath)
                .Replace("{MelonLoader.Utils.MelonEnvironment.ModsDirectory}", catalogDirPath);
            tempCatalog = Path.GetTempFileName();
            File.WriteAllText(tempCatalog, catalogText);
            catalogHandle = Addressables.LoadContentCatalogAsync(
                tempCatalog);
            catalogHandle.Completed += CatalogLoadCompleted;
        }

        private void CatalogLoadCompleted(AsyncOperationHandle<IResourceLocator> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                var results = handle.Result;
                assetKeys.Clear();
                assetKeys.Capacity = results.Keys.Count();
                foreach (var key in results.Keys)
                {
                    handle.Result.Locate(key, typeof(object), out var theStuff);
                    assetKeys.AddRange(theStuff);
                }
            }
            else
            {
                isCatalogLoadSucessfull = false;
                isLoadingCatalog = false;
                catalogError = handle.OperationException.ToString();
                File.Delete(tempCatalog);
                Debug.LogError("Failed to load content catalog: " + handle.OperationException);
                return;
            }

            foreach (var asset in assetKeys)
            {
                //var assetGUID = GenerateGuidFromStringSeed(asset.InternalId);
                var assetPath = asset.InternalId;

                if (!assetPath.StartsWith("Assets"))
                {
                    if (asset.ResourceType == typeof(IAssetBundleResource))
                        continue;
                    if (asset.ResourceType == typeof(SceneInstance))
                    {
                        assetPath = "Unnamed Assets/" + asset.ResourceType + "/" + asset.InternalId;
                        assetTree.AddAsset(asset, assetPath);
                        localCache.Add((asset, asset.ResourceType, assetPath));
                        continue;
                    }


                    if (asset.HasDependencies && asset.Dependencies.Count > 0)
                    {
                        if (asset.Dependencies[0].PrimaryKey.Contains("_previewmesh"))
                            assetPath = "Unnamed Assets/Preview Meshes/" +
                                        asset.Dependencies[0].PrimaryKey.Replace(".bundle", "");
                        else assetPath = "Unnamed Assets/" + asset.Dependencies[0].PrimaryKey.Replace(".bundle", "");
                    }
                    else
                    {
                        assetPath = "Unnamed Assets/" + asset.ResourceType + "/" + asset.PrimaryKey;
                    }

                    assetTree.AddAsset(asset, assetPath);
                    localCache.Add((asset, asset.ResourceType, assetPath));
                }
                else
                {
                    assetTree.AddAsset(asset, assetPath);
                    localCache.Add((asset, asset.ResourceType, assetPath));
                }
            }

            isLoadingCatalog = false;
            File.Delete(tempCatalog);
        }
    }
}