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

        public static T CreateAndSaveScriptableObject<T>() where T : ScriptableObject
        {
            var scriptableObject = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(scriptableObject, GetCurrentSelectedAssetPath() + $"/New {typeof(T)}.asset");
            EditorUtility.SetDirty(scriptableObject);
            Undo.RecordObject(scriptableObject, "CreateAndSaveScriptableObject");
            Selection.activeObject = scriptableObject;

            return scriptableObject;
        }

        public static AddressableAssetGroup CreateOrFindAddressableAssetGroup(AddressableAssetSettings settings,
            string groupName)
        {
            var group = settings.FindGroup(groupName);
            if (group != null) return group;
            group = settings.CreateGroup(groupName, true, false, true, null, typeof(ContentUpdateGroupSchema),
                typeof(BundledAssetGroupSchema));
            return group;
        }

        public static AddressableAssetEntry MarkAddressable(string assetPath, string assetAddress)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            var entry = settings.CreateOrMoveEntry(AssetDatabase.AssetPathToGUID(assetPath),
                CreateOrFindAddressableAssetGroup(settings,
                    AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                        AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName")));
            entry.SetAddress(assetAddress);

            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
            return entry;
        }
    }
}

#endif