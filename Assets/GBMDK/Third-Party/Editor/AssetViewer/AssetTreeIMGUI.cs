using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

/**
 * TreeNode.cs
 * Author: Luke Holland (http://lukeholland.me/)
 * Modified by a llama
 */

namespace TreeView
{
    public class AssetTreeIMGUI : TreeIMGUI<AssetData>
    {
        public ISceneProvider SceneProvider;
        private string selectedPrimaryKey = "";

        public AssetTreeIMGUI(TreeNode<AssetData> root) : base(root)
        {
        }

        protected override void OnDrawTreeNode(Rect rect, TreeNode<AssetData> node, bool selected, bool focus)
        {
            var iconTexture = node.HasChild(node.Data)
                ? EditorGUIUtility.FindTexture("Folder Icon")
                : EditorGUIUtility.ObjectContent(null, node.Data.asset.ResourceType).image;
            var labelContent = new GUIContent(node.Data.path, iconTexture);

            if (!node.IsLeaf)
                node.Data.isExpanded = EditorGUI.Foldout(new Rect(rect.x - 12, rect.y, 12, rect.height),
                    node.Data.isExpanded, GUIContent.none);


            EditorGUI.LabelField(rect, labelContent, selected ? EditorStyles.whiteLabel : EditorStyles.label);


            if (!selected || node.Data.asset.PrimaryKey == selectedPrimaryKey) return;

            if (node.Data.asset.ResourceType == typeof(SceneInstance))
            {
                selectedPrimaryKey = node.Data.asset.PrimaryKey;
                //AssetBundle.UnloadAllAssetBundles(false);
                var handle =
                    Addressables.ResourceManager.ProvideScene(new SceneProvider(), node.Data.asset,
                        LoadSceneMode.Single, true, 100);
                handle.Completed += operationHandle => { Debug.Log(operationHandle.DebugName); };
            }
            else
            {
                selectedPrimaryKey = node.Data.asset.PrimaryKey;
                //SaveDependencies(node.Data.asset);
                var newObject = Addressables.LoadAssetAsync<Object>(node.Data.asset);
                newObject.Completed += handle =>
                {
                    var newObject = handle.Result;

                    if (newObject is GameObject)
                    {
                        var newGameObject = Object.Instantiate(newObject) as GameObject;
                        var worldPos = SceneView.lastActiveSceneView.camera.transform.position +
                                       SceneView.lastActiveSceneView.camera.transform.forward;
                        newGameObject.transform.position = worldPos;
                        newObject = newGameObject;
                    }

                    Selection.objects = new[] { newObject };
                    Addressables.Release(handle);
                };
            }
        }
    }
}