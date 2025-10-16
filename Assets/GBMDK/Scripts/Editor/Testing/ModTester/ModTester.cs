using System;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace GBMDK.Editor
{
    public static class ModTester
    {
        private static string ExportedFolderPath => Path.Combine(Application.dataPath, "Exported");
        private static string GameFolderPath => GBMDKConfigSettings.instance.gameSettings.gameFolderPath;
        private static string GameExePath => Path.Combine(GameFolderPath, "Gang Beasts.exe");
        private static string ModsFolderPath => Path.Combine(GameFolderPath, "Mods");

        [MenuItem("GBMDK/Testing/Test Mod")]
        public static void TestMod()
        {
            RunMapTest();
        }

        public static void RunMapTest()
        {
            if (string.IsNullOrEmpty(GameFolderPath) || !File.Exists(GameExePath))
            {
                Debug.LogError("Please select Gang Beasts folder in GBMDK > Open Config.");
                return;
            }

            var settings = AddressableAssetSettingsDefaultObject.Settings;
            if (!settings)
            {
                Debug.LogError("Addressable settings not found!");
                return;
            }

            BuildShortcut.OnTrigger();
            CopyFolder();

            Process.Start(new ProcessStartInfo
            {
                FileName = GameExePath,
                UseShellExecute = true
            });
        }

        private static void CopyFolder()
        {
            try
            {
                var settings = AddressableAssetSettingsDefaultObject.Settings;
                var modName = settings.profileSettings.GetValueByName(settings.activeProfileId, "ModName");

                var sourceFolderPath = Path.Combine(ExportedFolderPath, modName);
                var destinationFolderPath = Path.Combine(ModsFolderPath, modName);

                // Check if the source folder exists
                if (Directory.Exists(sourceFolderPath))
                {
                    if (Directory.Exists(destinationFolderPath))
                        Directory.Delete(destinationFolderPath, true);
                    Directory.CreateDirectory(destinationFolderPath);

                    // Copy all files from the source to the destination folder
                    foreach (var file in Directory.GetFiles(sourceFolderPath))
                    {
                        var fileName = Path.GetFileName(file);
                        var destFile = Path.Combine(destinationFolderPath, fileName);
                        File.Copy(file, destFile, true); // Overwrite if file exists
                    }

                    // Optionally, copy subdirectories
                    foreach (var directory in Directory.GetDirectories(sourceFolderPath))
                    {
                        var dirName = Path.GetFileName(directory);
                        var destDir = Path.Combine(destinationFolderPath, dirName);
                        Directory.CreateDirectory(destDir);
                        foreach (var file in Directory.GetFiles(directory))
                        {
                            var fileName = Path.GetFileName(file);
                            var destFile = Path.Combine(destDir, fileName);
                            File.Copy(file, destFile, true); // Overwrite if file exists
                        }
                    }

                    Debug.Log("Folder copied successfully!");
                }
                else
                {
                    Debug.LogError("Source folder does not exist: " + sourceFolderPath);
                }
            }
            catch (Exception e)
            {
                Debug.LogError("Error copying folder: " + e);
            }
        }
    }
}