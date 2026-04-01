#if UNITY_EDITOR

using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
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

        public static AddressableAssetGroup CreateOrFindAddressableAssetGroup(AddressableAssetSettings settings,
            string groupName, bool setAsDefault=false)
        {
            var group = settings.FindGroup(groupName);
            if (group != null) return group;
            group = settings.CreateGroup(groupName, setAsDefault, false, true, null, typeof(ContentUpdateGroupSchema),
                typeof(BundledAssetGroupSchema));
            EditorUtility.SetDirty(group);
            return group;
        }

        public static AddressableAssetEntry MarkAddressable(string assetPath, string assetAddress, string groupName = "")
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            AssetDatabase.RenameAsset(assetPath, assetAddress);
            var entry = settings.CreateOrMoveEntry(AssetDatabase.AssetPathToGUID(assetPath),
                CreateOrFindAddressableAssetGroup(settings, string.IsNullOrWhiteSpace(groupName) ?
                    AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                        AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName") : groupName));
            entry.SetAddress(assetAddress);

            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
            return entry;
        }
    }
}

#endif