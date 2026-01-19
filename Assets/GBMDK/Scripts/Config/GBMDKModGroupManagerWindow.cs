#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;
using UnityEngine.UIElements;

namespace GBMDK.Editor
{
    [Serializable]
    public class GBMDKModGroup
    {
        public string folderPath;
        public AddressableAssetGroup assetGroup;
        public bool selected;

        public bool IsActiveMod => assetGroup.Default ||
                                   AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                                       AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName") ==
                                   assetGroup.Name;
    }

    [FilePath("Exported/ModGroups.asset", FilePathAttribute.Location.ProjectFolder)]
    public class GBMDKModGroupManager : ScriptableSingleton<GBMDKModGroupManager>
    {
        public List<GBMDKModGroup> modGroups;
        public int sessionGroupsId;

        private void OnEnable()
        {
            hideFlags &= ~HideFlags.NotEditable;
        }

        private void OnValidate()
        {
            for (var i = 0; i < modGroups.Count; i++)
            {
                var modGroup = modGroups[i];
                if (modGroup == null)
                    modGroups.RemoveAt(i);
                else if (string.IsNullOrWhiteSpace(modGroup?.folderPath) || modGroup.assetGroup == null)
                    DeleteModGroup(modGroup);
            }
        }

        public GBMDKModGroup CreateAndRegisterModGroup(string groupName = null)
        {
            if (string.IsNullOrWhiteSpace(groupName)) groupName = $"NewMod{modGroups.Count + sessionGroupsId}";
            var folderPath = $"Assets/Mods/{groupName}";
            AssetDatabase.CreateFolder("Assets/Mods", groupName);
            var assetGroup =
                Common.CreateOrFindAddressableAssetGroup(AddressableAssetSettingsDefaultObject.Settings, groupName);
            var group = new GBMDKModGroup
            {
                folderPath = folderPath,
                assetGroup = assetGroup
            };
            modGroups.Add(group);

            sessionGroupsId++;
            AssetDatabase.Refresh();
            return group;
        }

        public GBMDKModGroup RenameModGroup([CanBeNull] string groupName, string newGroupName)
        {
            if (string.IsNullOrWhiteSpace(groupName) || string.IsNullOrWhiteSpace(newGroupName)) return null;
            var group = modGroups.Find(x => x.assetGroup.Name == groupName);
            group.assetGroup.Name = newGroupName;
            var folderPath = $"Assets/Mods/{newGroupName}";
            var err = AssetDatabase.MoveAsset(group.folderPath, folderPath);
            if (!string.IsNullOrWhiteSpace(err))
                Debug.LogError($"Failed to move folder {group.folderPath} to {folderPath}: {err}");
            return group;
        }

        public void DeleteModGroup(GBMDKModGroup group)
        {
            if (group.assetGroup != null) AddressableAssetSettingsDefaultObject.Settings.RemoveGroup(group.assetGroup);

            if (!string.IsNullOrWhiteSpace(group.folderPath)) AssetDatabase.DeleteAsset(group.folderPath);

            modGroups.Remove(group);

            AssetDatabase.Refresh();
        }
    }

    public class GBMDKModGroupManagerWindow : EditorWindow
    {
        private void CreateGUI()
        {
            titleContent = new GUIContent("GBMDK Mod Group Manager");
            var activeCheck = new DropdownField("Active Mod");
            activeCheck.value = AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName");

            if (GBMDKModGroupManager.instance.modGroups == null || GBMDKModGroupManager.instance.modGroups.Count == 0)
            {
                var noneFoundLabel = new Label("No Mod Groups found!");
                rootVisualElement.Add(noneFoundLabel);

                if (GBMDKModGroupManager.instance.modGroups == null)
                    return;
            }

            foreach (var modGroup in GBMDKModGroupManager.instance.modGroups)
            {
                if (modGroup == null) continue;
                var selectionToggle = new Toggle("Selected:")
                {
                    value = modGroup.selected
                };
                selectionToggle.RegisterValueChangedCallback(evt => { modGroup.selected = evt.newValue; });
                var containerElement = new VisualElement();
                activeCheck.choices.Add(modGroup.assetGroup.Name);
                activeCheck.RegisterValueChangedCallback(evt =>
                {
                    if (evt.newValue != modGroup.assetGroup.Name) return;
                    if (!AddressableAssetSettingsDefaultObject.SettingsExists) return;

                    AddressableAssetSettingsDefaultObject.Settings.DefaultGroup = modGroup.assetGroup;
                    AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                        AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName", evt.newValue);
                    AddressableAssetSettingsDefaultObject.Settings.ShaderBundleCustomNaming =
                        AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                            AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName");
                });
                var modGroupName = new Label(modGroup.assetGroup.Name);
                var entriesFoldout = new Foldout
                {
                    text = "Entries"
                };
                var addEntryButton = new Button
                {
                    text = "Add Entry"
                };
                var removeEntryButton = new Button
                {
                    text = "Remove Entry"
                };
                containerElement.Add(modGroupName);
                containerElement.Add(selectionToggle);
                containerElement.Add(entriesFoldout);
                foreach (var entry in modGroup.assetGroup.entries)
                {
                    var entryElement = new VisualElement();
                    var entryDetailsFoldout = new Foldout();
                    var entryAddressLabel = new Label($"ADDRESS: {entry.address}");
                    var entryGuidLabel = new Label($"GUID: {entry.guid}");
                    var entryPathLabel = new Label($"PATH: {entry.AssetPath}");

                    entryDetailsFoldout.Add(entryGuidLabel);
                    entryDetailsFoldout.Add(entryAddressLabel);
                    entryDetailsFoldout.Add(entryPathLabel);
                    entryElement.Add(entryDetailsFoldout);
                }

                entriesFoldout.Add(addEntryButton);
                entriesFoldout.Add(removeEntryButton);
                rootVisualElement.Add(containerElement);
            }

            var createGroupInput = new TextField("New Group Name (OPTIONAL):");
            var createGroupButton =
                new Button(() =>
                {
                    var modGroup = GBMDKModGroupManager.instance.CreateAndRegisterModGroup(createGroupInput.value);
                    activeCheck.value = modGroup.assetGroup.Name;

                    Close();
                    ShowWindow();
                })
                {
                    text = "Create Group"
                };
            var renameActiveInput = new TextField("New Active Group Name:");
            var renameActiveButton = new Button(() =>
            {
                if (string.IsNullOrWhiteSpace(renameActiveInput.value)) return;
                GBMDKModGroupManager.instance.RenameModGroup(
                    GBMDKModGroupManager.instance.modGroups.ToArray().FirstOrDefault(g => g.IsActiveMod)?.assetGroup
                        ?.Name, renameActiveInput.value);
            })
            {
                text = "Rename Active Group"
            };
            var removeActiveButton = new Button(() =>
            {
                foreach (var group in GBMDKModGroupManager.instance.modGroups.ToArray().Where(g => g.IsActiveMod))
                    GBMDKModGroupManager.instance.DeleteModGroup(group);

                activeCheck.value = GBMDKModGroupManager.instance.modGroups.LastOrDefault()?.assetGroup?.Name ?? "NULL";
                Close();
                ShowWindow();
            })
            {
                text = "Remove Active Group"
            };
            var removeSelectedButton = new Button(() =>
            {
                foreach (var group in GBMDKModGroupManager.instance.modGroups.ToArray().Where(g => g.selected))
                    GBMDKModGroupManager.instance.DeleteModGroup(group);

                activeCheck.value = GBMDKModGroupManager.instance.modGroups.LastOrDefault()?.assetGroup?.Name ?? "NULL";
                Close();
                ShowWindow();
            })
            {
                text = "Remove Selected Groups"
            };

            rootVisualElement.Add(activeCheck);
            rootVisualElement.Add(createGroupInput);
            rootVisualElement.Add(createGroupButton);
            rootVisualElement.Add(renameActiveInput);
            rootVisualElement.Add(renameActiveButton);
            rootVisualElement.Add(removeActiveButton);
            rootVisualElement.Add(removeSelectedButton);
        }

        [MenuItem("GBMDK/Open Mod Group Manager")]
        public static void ShowWindow()
        {
            GetWindow<GBMDKModGroupManagerWindow>();
        }
    }
}
#endif