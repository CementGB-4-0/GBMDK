using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace GBMDK.Editor
{
    public class GBMDKConfigSettingsWindow : EditorWindow
    {
        [MenuItem("GBMDK/Open Config")]
        public static void ShowWindow()
        {
            var wnd = GetWindow<GBMDKConfigSettingsWindow>();
            wnd.titleContent = new GUIContent("GBMDK Config");
        }
        
        private void CreateGUI()
        {
            var root = rootVisualElement;
            if (!GBMDKConfigSettings.instance) return;
            
            var editor = new InspectorElement(GBMDKConfigSettings.instance);

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
                tooltip = "Launch arguments to pass to Gang Beasts on load. Ignore this if you don't know what you're doing",
                value = GBMDKConfigSettings.instance.gameSettings.launchArgs
            };

            launchArgsFld.RegisterValueChangedCallback(evt =>
            {
                GBMDKConfigSettings.instance.gameSettings.launchArgs = evt.newValue;
                GBMDKConfigSettings.instance.Save();
            });
            
            var gameSettingsLbl = new Foldout()
            {
                text = "Game Settings",
            };
            
            gameSettingsLbl.Add(gamePathBtn);
            gameSettingsLbl.Add(launchArgsFld);
            
            root.Add(gameSettingsLbl);
            root.Add(editor);
        }
    }
}
