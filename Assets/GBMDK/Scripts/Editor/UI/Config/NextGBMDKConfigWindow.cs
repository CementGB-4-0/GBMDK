using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class NextGBMDKConfigWindow : EditorWindow
{
    public void CreateGUI()
    {
        var root = rootVisualElement;

        var visualTree =
            AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
                "Assets/GBMDK/Scripts/Editor/UI/Config/NextGBMDKConfigWindow.uxml");
        var windowObj = visualTree.Instantiate();
        root.Add(windowObj);
    }

    [MenuItem("Window/UI Toolkit/NextGBMDKConfigWindow")]
    public static void ShowExample()
    {
        var wnd = GetWindow<NextGBMDKConfigWindow>();
        wnd.titleContent = new GUIContent("NextGBMDKConfigWindow");
    }
}