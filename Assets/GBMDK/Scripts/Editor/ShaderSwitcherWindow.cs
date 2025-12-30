using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class ShaderSwitcherWindow : EditorWindow
    {
        private Shader _replaceWith;
        private Shader _toReplace;
        private string _toReplaceName;

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            var toReplaceNameShader = Shader.Find(_toReplaceName);
            if (toReplaceNameShader != null)
            {
                EditorGUILayout.LabelField($"Replace using name: {_toReplaceName} (VALID)",
                    EditorStyles.centeredGreyMiniLabel);
                _toReplace = toReplaceNameShader;
            }
            else
            {
                _toReplace =
                    (Shader)EditorGUILayout.ObjectField("Shader to Replace", _toReplace, typeof(Shader), false);
            }

            EditorGUILayout.LabelField("----- Optional -----", EditorStyles.boldLabel);
            _toReplaceName = EditorGUILayout.TextField("Shader Name to Replace", _toReplaceName);
            EditorGUILayout.LabelField("----------", EditorStyles.boldLabel);
            _replaceWith =
                (Shader)EditorGUILayout.ObjectField("Replacement Shader", _replaceWith, typeof(Shader), false);

            if (GUILayout.Button("Replace!"))
                ReplaceShaders();
            EditorGUILayout.EndVertical();
        }

        [MenuItem("Tools/GBMDK/Shader Switcher")]
        public static void ShowWindow()
        {
            GetWindow<ShaderSwitcherWindow>(title: "Shader Switcher", utility: true);
        }

        private void ReplaceShaders()
        {
            if (_toReplace == null || _replaceWith == null) return;

            foreach (var renderer in FindObjectsOfType<MeshRenderer>())
            foreach (var material in renderer.sharedMaterials)
                if (material.shader.name == _toReplace.name)
                    material.shader = _replaceWith;
        }
    }
}