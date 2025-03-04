using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class ModWizardWindow : EditorWindow
    {
        private static ModWizardModInfo selectedModSettings;

        //[MenuItem("Tools/GBMDK/Mod Wizard", priority = 10)]
        public static ModWizardWindow OpenWindow()
        {
            var window = GetWindow<ModWizardWindow>("Mod Wizard");
            window.Show();

            return window;
        }

        private void OnAddButtonPressed()
        {
            ModWizardCore.CreateMod();
            Repaint();
        }

        private void OnRemoveButtonPressed()
        {
            if (selectedModSettings != null)
            {
                ModWizardCore.RemoveMod();
                Repaint();
            }
        }

        private void OnGUI()
        {
            GUILayout.BeginVertical();

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Add", EditorStyles.toolbarButton))
            {
                OnAddButtonPressed();
            }

            if (GUILayout.Button("Remove", EditorStyles.toolbarButton))
            {
                OnRemoveButtonPressed();
            }

            GUILayout.EndHorizontal();

            if (ModWizardCore.Mods.Count > 0)
            {
                GUILayout.BeginScrollView(Vector2.zero);

                foreach (var mod in ModWizardCore.Mods)
                {
                    GUILayout.BeginHorizontal();

                    var modInfo = ModWizardCore.GetMod(mod.Key);

                    modInfo.CurrentlyActive = GUILayout.Toggle(modInfo.CurrentlyActive, "Set Active");
                    GUILayout.Label(mod.Key, EditorStyles.boldLabel);

                    GUILayout.EndHorizontal();
                }

                GUILayout.EndScrollView();
            }
            else
            {
                GUILayout.Label("No mods found!\nCreate one with the \"Add\" button above.", EditorStyles.boldLabel);
            }

            GUILayout.EndVertical();
        }
    }
}