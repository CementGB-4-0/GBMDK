using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GBMDK.Editor
{
    public static class Common
    {
        public static bool IsHandleSuccess(AsyncOperationHandle handle)
        {
            return handle.IsValid() &&
                   handle is { Status: AsyncOperationStatus.Succeeded, Result: not null };
        }
        
        public static string GetCurrentSelectedAssetPath()
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
                path = "Assets";
            else if (Path.GetExtension(path) != "")
                path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

            return path;
        }

        public static T CreateAndSaveScriptableObject<T>() where T : ScriptableObject
        {
            var scriptableObject = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(scriptableObject, GetCurrentSelectedAssetPath() + $"/New {typeof(T)}.asset");
            EditorUtility.SetDirty(scriptableObject);
            Undo.RecordObject(scriptableObject, "CreateAndSaveScriptableObject");
            Selection.activeObject = scriptableObject;

            return scriptableObject;
        }
    }
}