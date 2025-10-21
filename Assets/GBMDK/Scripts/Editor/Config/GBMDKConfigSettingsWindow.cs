using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace GBMDK.Editor
{
    public class GBMDKConfigSettingsWindow : EditorWindow
    {
        private void OnGUI()
        {
            if (AddressableAssetSettingsDefaultObject.SettingsExists)
                AddressableAssetSettingsDefaultObject.Settings.ShaderBundleCustomNaming =
                    AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                        AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName");
        }

        private void CreateGUI()
        {
            var root = rootVisualElement;
            if (!GBMDKConfigSettings.instance) return;

            var editorFoldout = new Foldout
            {
                text = "Inspector"
            };
            var editor = new InspectorElement(GBMDKConfigSettings.instance);

            var activeModNameFld = new TextField("Active Mod Name")
            {
                value = AddressableAssetSettingsDefaultObject.SettingsExists
                    ? AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                        AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName")
                    : ""
            };
            if (AddressableAssetSettingsDefaultObject.SettingsExists)
                AddressableAssetSettingsDefaultObject.Settings.ShaderBundleCustomNaming = activeModNameFld.value;

            activeModNameFld.RegisterValueChangedCallback(evt =>
            {
                if (!AddressableAssetSettingsDefaultObject.SettingsExists) return;
                AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                    AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName", evt.newValue);
            });

            var gamePathBtn = new Button(() =>
            {
                var gameFolderPathish = EditorUtility.OpenFolderPanel("Select Gang Beasts Folder", "", "");
                if (string.IsNullOrWhiteSpace(gameFolderPathish)) return;

                GBMDKConfigSettings.instance.gameSettings.gameFolderPath = gameFolderPathish;
                GBMDKConfigSettings.instance.Save();
            })
            {
                text = "Select Gang Beasts Folder"
            };

            var launchArgsFld = new TextField
            {
                label = "Launch Arguments",
                tooltip =
                    "Launch arguments to pass to Gang Beasts on load. Ignore this if you don't know what you're doing",
                value = GBMDKConfigSettings.instance.gameSettings.launchArgs
            };

            launchArgsFld.RegisterValueChangedCallback(evt =>
            {
                GBMDKConfigSettings.instance.gameSettings.launchArgs = evt.newValue;
                GBMDKConfigSettings.instance.Save();
            });

            var modSettingsLbl = new Foldout
            {
                text = "Mod Settings"
            };

            var gameSettingsLbl = new Foldout
            {
                text = "Game Settings"
            };

            gameSettingsLbl.Add(gamePathBtn);
            gameSettingsLbl.Add(launchArgsFld);

            modSettingsLbl.Add(activeModNameFld);

            root.Add(gameSettingsLbl);
            root.Add(modSettingsLbl);
            root.Add(editorFoldout);
            editorFoldout.Add(editor);
        }

        [InitializeOnLoadMethod]
        private static void OnEditorLoad()
        {
            if (GBMDKConfigSettings.IsFirstRun)
            {
                ShowWindow();
                EditorPrefs.SetBool(GBMDKConfigSettings.GBMDKFirstRunKey, false);
            }
        }

        [MenuItem("GBMDK/Open Config")]
        public static void ShowWindow()
        {
            var wnd = GetWindow<GBMDKConfigSettingsWindow>();
            wnd.titleContent = new GUIContent("GBMDK Config");
        }
    }
}