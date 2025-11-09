using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace GBMDK.Editor
{
    public static class BuildShortcut
    {
        [MenuItem("GBMDK/Build Addressable Content", priority = 10)]
        public static void OnTrigger()
        {
            var outputPath = Path.Combine(Application.dataPath, "Exported");
            if (Directory.Exists(outputPath))
                Directory.Delete(outputPath, true);
            Directory.CreateDirectory(outputPath);
            ShaderViewer.OnDisable();
            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();
            AddressableAssetSettings.BuildPlayerContent();
        }

        [MenuItem("GBMDK/Build AssetBundles", priority = 10)]
        public static void OnTriggerAB()
        {
            var outputPath = Path.Combine(Application.dataPath, "Exported", "AssetBundles");
            if (Directory.Exists(outputPath))
                Directory.Delete(outputPath, true);
            Directory.CreateDirectory(outputPath);
            BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        }
    }
}