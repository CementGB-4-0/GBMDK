#if UNITY_EDITOR

using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
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

        public static AddressableAssetEntry MarkAddressable(string assetPath, string assetAddress)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            var entry = settings.CreateOrMoveEntry(AssetDatabase.AssetPathToGUID(assetPath), settings.DefaultGroup);
            entry.SetAddress(assetAddress);

            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
            return entry;
        }
    }
}

#endif