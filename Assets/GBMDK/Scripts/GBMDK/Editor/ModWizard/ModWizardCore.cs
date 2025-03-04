using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using UnityEngine;

namespace GBMDK.Editor
{
    public static class ModWizardCore
    {
        public static readonly string BaseModsAssetFolderPath = Path.GetRelativePath(Path.Combine(Application.dataPath, ".."), Path.Combine(Application.dataPath, "Mods"));
        public static Dictionary<string, string> Mods // { modName : infoObjGuid }
        { 
            get
            {
                var ret = new Dictionary<string, string>();

                foreach (var dir in Directory.GetDirectories(BaseModsAssetFolderPath))
                {
                    var dirname = Path.GetFileNameWithoutExtension(dir);
                    if (ValidateMod(dirname))
                    {
                        var infoGuid = AssetDatabase.AssetPathToGUID(Path.Combine(dir, "ModWizardData", $"{dirname}-Info.asset"));
                        ret.Add(dirname, infoGuid);
                    }
                }

                Debug.LogAssertion("No mods!");
                return _mods.Count != ret.Count ? ret : _mods;
            }
        }
        private static Dictionary<string, string> _mods = new();

        /// <summary>
        /// Creates a new Addressable group by passed name and returns it, or returns the existing group with that name.
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="removeExisting"></param>
        /// <returns>A new Addressable group with the passed name, or the existing group with that name.</returns>
        private static AddressableAssetGroup CreateAddressableGroup(string groupName, bool removeExisting = false)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;

            if (settings != null)
            {
                var group = settings.FindGroup(groupName);
                if (group != null)
                {
                    if (removeExisting) settings.RemoveGroup(group);
                    else
                    {
                        Debug.LogWarning($"Cannot create new Addressable group: Group with name \"{groupName}\" already exists! Returning existing group. . .");
                        return group;
                    }
                }

                group = settings.CreateGroup(groupName, false, false, true, null, typeof(ContentUpdateGroupSchema), typeof(BundledAssetGroupSchema));

                return group;
            }

            Debug.LogError("Addressable Asset Settings are null! Are Addressables initialized in the editor?");
            return null;
        }

        public static ModWizardModInfo GetMod(string name)
        {
            foreach (var mod in Mods)
            {
                if (mod.Key == name)
                {
                    var infoObjPath = AssetDatabase.GUIDToAssetPath(mod.Value);
                    var infoObj = (ModWizardModInfo)AssetDatabase.LoadAssetAtPath(infoObjPath, typeof(ModWizardModInfo));

                    return infoObj;
                }
            }

            return null;
        }

        public static ModWizardModInfo CreateMod(string name = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                name = $"NewMod_{Mods.Count}";

            if (ValidateMod(name))
                return GetMod(name);

            var newModInfo = ScriptableObject.CreateInstance<ModWizardModInfo>();
            newModInfo.name = name;

            var newGroup = CreateAddressableGroup(name);
            if (!newGroup)
                throw new System.Exception($"Failed to create mod with name \"{name}\": {nameof(CreateAddressableGroup)} returned null!");

            var newModRefs = ScriptableObject.CreateInstance<ModWizardModInfo_Refs>();
            newModRefs.addressablesGroup = newGroup;
            newModRefs.assetsFolderPath = Path.Combine(BaseModsAssetFolderPath, name);

            newModInfo.refs = newModRefs;

            var modWizardDataPath = Path.Combine(newModRefs.assetsFolderPath, "ModWizardData");
            Directory.CreateDirectory(modWizardDataPath);

            AssetDatabase.CreateAsset(newModInfo, Path.Combine(modWizardDataPath, $"{name}-Info.asset"));
            AssetDatabase.CreateAsset(newModRefs, Path.Combine(modWizardDataPath, $"{name}-Refs.asset"));

            EditorUtility.SetDirty(newModInfo);
            EditorUtility.SetDirty(newModRefs);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            return newModInfo;
        }

        public static bool ValidateMod(string name)
        {
            var dir = Path.Combine(BaseModsAssetFolderPath, name);
            if (!Directory.Exists(dir))
                return false;

            var settings = AddressableAssetSettingsDefaultObject.Settings;
            var dirname = Path.GetFileNameWithoutExtension(dir);
            var wizardDataPath = Path.GetFullPath(Path.Combine(dir, "ModWizardData"));

            Debug.Log(wizardDataPath);
            if (settings)
            {
                return settings.FindGroup(dirname) 
                    && Directory.Exists(wizardDataPath) 
                    && File.Exists(Path.Combine(wizardDataPath, $"{dirname}-Info.asset"))
                    && File.Exists(Path.Combine(wizardDataPath, $"{dirname}-Refs.asset"));
            }

            Debug.LogError("Addressable Asset Settings are null! Are Addressables initialized in the editor?");
            return false;
        }

        public static void RemoveMod(string name = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                if (Mods.Count > 0)
                {
                    name = Mods.Keys.Last();
                }
                else return; // No mods are here to remove, so just do nothing
            }
            Debug.Log($"Removing mod {name}. . .");

            var settings = AddressableAssetSettingsDefaultObject.Settings;
            if (settings)
            {
                var directory = Path.Combine(BaseModsAssetFolderPath, name);
                if (Directory.Exists(directory))
                    Directory.Delete(directory, true);

                var group = settings.FindGroup(name);
                if (group)
                    settings.RemoveGroup(group);

                return;
            }

            Debug.LogError("Addressable Asset Settings are null! Are Addressables initialized in the editor?");
        }
    }
}