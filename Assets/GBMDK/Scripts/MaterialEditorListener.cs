#if UNITY_EDITOR
using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class MaterialSaveDetector : AssetModificationProcessor
    {
        private static string[] OnWillSaveAssets(string[] paths)
        {
            foreach (var path in paths)
            {
                if (Path.GetExtension(path) == ".mat")
                {
                    var material = AssetDatabase.LoadAssetAtPath<Material>(path);
                    if (material != null) material.shader = Shader.Find(material.shader.name);
                }
            }

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