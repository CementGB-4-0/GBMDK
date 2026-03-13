#if UNITY_EDITOR

using System.IO;
using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public static class Common
    {
        public static string GetCurrentSelectedAssetPath()
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
                path = "Assets";
            else if (Path.GetExtension(path) != "")
                path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

            return path;
        }

        public static T CreateAndSaveScriptableObject<T>(string name = "") where T : ScriptableObject
        {
            if (string.IsNullOrWhiteSpace(name)) name = $"New {typeof(T).Name}";
            
            var scriptableObject = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(scriptableObject, GetCurrentSelectedAssetPath() + $"/{name}.asset");
            EditorUtility.SetDirty(scriptableObject);
            Undo.RecordObject(scriptableObject, nameof(CreateAndSaveScriptableObject));
            Selection.activeObject = scriptableObject;

            return scriptableObject;
        }
    }
}

#endif