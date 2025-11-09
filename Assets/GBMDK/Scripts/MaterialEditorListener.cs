#if UNITY_EDITOR
using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class MyAssetModificationProcessor : AssetModificationProcessor
    {
        public static string[] OnWillSaveAssets(string[] paths)
        {
            // Get the name of the scene to save.
            var scenePath = string.Empty;
            var sceneName = string.Empty;

            foreach (var path in paths)
                if (path.Contains(".unity") || path.Contains(".mat"))
                {
                    scenePath = Path.GetDirectoryName(path);
                    sceneName = Path.GetFileNameWithoutExtension(path);
                }

            if (sceneName.Length == 0) return paths;

            ShaderViewer.instance.OnDisable();

            return paths;
        }
    }

    [CustomEditor(typeof(Material))]
    public class MaterialEditorListener : MaterialEditor
    {
        public static Action<Material> ShaderChangedEvent;

        protected override void OnShaderChanged()
        {
            ShaderChangedEvent?.Invoke(target as Material);
        }
    }
}
#endif