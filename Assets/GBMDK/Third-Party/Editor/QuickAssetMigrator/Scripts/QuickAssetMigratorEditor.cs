using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using GBMDK.Editor;
using SFB;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace FizzSDK.QuickAssetMigrator
{
    public class QuickAssetMigratorEditor : EditorWindow, IHasCustomMenu
    {
        private const string AssetMigratorRepository = "https://github.com/Fizzyhex/asset_migrator_extsdk";
        private const string ConversionOutputFolderName = "ConversionOutput";
        private static bool _shouldMigrateScripts;
        private static bool _shouldMigrateShaders = true;
        private static bool _shouldMigratePlugins;
        private static string _sourceFolder;
        private readonly List<string> _selectedAssets = new();
        private bool _hasMigrated;
        private bool _infoFoldoutVisible;
        private bool _isAssetMigratorPresent = true;
        private bool _isFocused;
        private string _migratorArguments;

        private static string assetsFullPath;
        private static string ConversionOutputPath => $"{ConversionOutputFolderName}";
        
        private void OnEnable()
        {
            assetsFullPath = Application.dataPath;
            _sourceFolder = File.Exists(Path.Combine($"{GetWorkingDirectory()}", "source_folder_saved.txt"))
                ? File.ReadAllText(Path.Combine(GetWorkingDirectory(), "source_folder_saved.txt"))
                : string.Empty;
        }

        private void OnGUI()
        {
            var wasFocused = _isFocused;
            _isFocused = focusedWindow == this;

            if (wasFocused != _isFocused)
                _isAssetMigratorPresent = CheckForAssetMigrator();

            if (!_isAssetMigratorPresent)
            {
                EditorGUILayout.BeginVertical(GUI.skin.box);
                EditorGUILayout.HelpBox(
                    $"asset_migrator.exe is missing! Please drag it underneath {GetWorkingDirectory()} in your project.",
                    MessageType.Error);

                if (GUILayout.Button("Open Repository")) Application.OpenURL(AssetMigratorRepository);

                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
                EditorGUI.BeginDisabledGroup(true);
            }

            if (GUILayout.Button("Select Source Folder"))
            {
                var path = StandaloneFileBrowser.OpenFolderPanel("Select Folder", "", false);

                if (!string.IsNullOrWhiteSpace(path.FirstOrDefault()))
                {
                    _sourceFolder = path[0];
                    File.WriteAllText(Path.Combine(GetWorkingDirectory(), "source_folder_saved.txt"), _sourceFolder);
                    AssetDatabase.Refresh();
                }
            }

            if (_sourceFolder is { Length: > 0 })
            {
                EditorGUILayout.BeginVertical(GUI.skin.box);
                EditorGUILayout.LabelField("Asset Selection", EditorStyles.boldLabel);

                GUILayout.Label($"Source: {_sourceFolder}");
                GUILayout.Label($"{_selectedAssets.Count} selected file(s)");

                if (GUILayout.Button("Add Assets"))
                {
                    var targetExtensions = new[]
                    {
                        new ExtensionFilter("Assets", GetExtensions())
                    };

                    var paths = StandaloneFileBrowser.OpenFilePanel("Select Assets", _sourceFolder, targetExtensions,
                        true);

                    foreach (var path in paths)
                    {
                        if (_selectedAssets.Contains(path)) continue;
                        if (!IsInDirectory(path, _sourceFolder))
                        {
                            Debug.LogWarning(
                                $"Asset '{path}' was not added as it's not underneath source folder '{_sourceFolder}'!");
                            continue;
                        }

                        _selectedAssets.Add(path);
                    }
                }

                if (GUILayout.Button("Add Folder"))
                {
                    var paths = StandaloneFileBrowser.OpenFolderPanel("Select Folder", _sourceFolder, true);

                    foreach (var path in paths)
                    {
                        if (_selectedAssets.Contains(path)) continue;
                        if (!IsInDirectory(path, _sourceFolder))
                        {
                            Debug.LogWarning(
                                $"Folder '{path}' was not added as it's not underneath source folder '{_sourceFolder}'!");
                            continue;
                        }

                        _selectedAssets.Add(path);
                    }
                }

                EditorGUI.BeginDisabledGroup(_selectedAssets.Count == 0);
                if (GUILayout.Button("Clear Selection"))
                    if (EditorUtility.DisplayDialog("Clear selected assets?",
                            "Are you sure you want to clear the selected assets?", "Yes", "No"))
                        _selectedAssets.Clear();

                EditorGUI.EndDisabledGroup();
            }

            GUILayout.EndVertical();

            EditorGUILayout.Space();

            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.LabelField("Export Settings", EditorStyles.boldLabel);

            _infoFoldoutVisible = EditorGUILayout.Foldout(_infoFoldoutVisible, "Information");
            if (_infoFoldoutVisible)
            {
                // not wrapping this line :3
                EditorGUILayout.HelpBox(
                    "If these boxes are un-ticked, content will be deleted upon migration. If you're migrating ripped content, you likely want to leave 'keep shaders' and 'keep scripts' un-ticked, as you will only have access to dummy scripts/shaders.",
                    MessageType.Info);
                EditorGUILayout.EndFoldoutHeaderGroup();
            }

            _shouldMigrateScripts = EditorGUILayout.Toggle("Keep Scripts", _shouldMigrateScripts);
            _shouldMigrateShaders = EditorGUILayout.Toggle("Keep Shaders", _shouldMigrateShaders);
            _shouldMigratePlugins = EditorGUILayout.Toggle("Keep Plugins", _shouldMigratePlugins);

            EditorGUILayout.EndVertical();

            EditorGUILayout.Space();

            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.LabelField("Migration", EditorStyles.boldLabel);
            var migrationPressed = GUILayout.Button("Migrate!");

            if (GUILayout.Button("Copy arguments to clipboard"))
            {
                EditorGUIUtility.systemCopyBuffer =
                    SplitMigratorArgs(MakeMigrationArgs(_sourceFolder, _selectedAssets));
                Debug.Log("Copied to clipboard!");
            }

            if (migrationPressed)
            {
                BeginMigrate().Forget();
            }

            if (_hasMigrated) EditorGUILayout.LabelField($"Outputted to Assets/{ConversionOutputPath}!");

            EditorGUILayout.EndVertical();
        }

        private async UniTaskVoid BeginMigrate()
        {
            var workingDirectory = GetWorkingDirectory();
            Debug.Log("Working directory:" + workingDirectory);
            _migratorArguments = SplitMigratorArgs(MakeMigrationArgs(_sourceFolder, _selectedAssets));
            
            await StartExternalProcessing(workingDirectory);
            // await UniTask.SwitchToMainThread(); // Hangs the editor indefinitely????
            OnExternalProcessingComplete();
        }

        private async UniTask StartExternalProcessing(string workingDirectory)
        {
            Debug.Log($"Running external process with arguments: {_migratorArguments}");
            
            var startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(workingDirectory, "asset_migrator.exe"),
                Arguments = _migratorArguments,
                UseShellExecute = false,
                WorkingDirectory = assetsFullPath,
                RedirectStandardOutput = true
            };
            var process = new Process();
            process.StartInfo = startInfo;
            process.EnableRaisingEvents = true;
            var utcs = new UniTaskCompletionSource<int>();

            process.Exited += (_, _) =>
            {
                utcs.TrySetResult(process.ExitCode);
                process.Dispose();
            };
            process.Start();
            await utcs.Task.AsUniTask();
        }

        private void OnExternalProcessingComplete()
        {
            Debug.Log("External process ran and I received exit event, removing redundancies and resolving new guids. . .");
            var conversionOutput = assetsFullPath + "/" + ConversionOutputPath;
            Directory.CreateDirectory(conversionOutput);
            var conversionOutputFiles = Directory.GetFiles(conversionOutput, "*", SearchOption.AllDirectories);
            Debug.Log($"Iterating file count: {conversionOutputFiles.Length.ToString()}");

            foreach (var file in conversionOutputFiles)
            {
                var assetPath = Common.FullPathToUnityPath(assetsFullPath, file); // Uses FileUtil API, which errors due to it not being called on main thread
                var oldGuid = AssetDatabase.AssetPathToGUID(assetPath);
                var extension = Path.GetExtension(file);
                var isScript = extension is ".cs" or ".asmdef";
                var isShader = extension is ".shader" or ".shadergraph";
                var isPlugin = extension == ".dll";
                var shouldDelete = (isPlugin && !_shouldMigratePlugins) || (isScript && !_shouldMigrateScripts) || (isShader && !_shouldMigrateShaders);

                if (shouldDelete) File.Delete(file);

                var guidWritten = ResolveNewGuidReference(GetMetaReferences(oldGuid), oldGuid, Path.GetFileName(file), extension);
                Debug.Assert(guidWritten);
            }

            var folderObject = AssetDatabase.LoadAssetAtPath<Object>(ConversionOutputFolderName);
            EditorUtility.FocusProjectWindow();
            AssetDatabase.OpenAsset(folderObject);
            AssetDatabase.Refresh();

            _hasMigrated = true;
            Debug.Log("Done!");
        }

        string[] GetMetaReferences(string guid)
        {
            return Directory.GetFiles(Path.GetDirectoryName(assetsFullPath)!, "*.*", SearchOption.AllDirectories)
                .Where(metaFile =>
                {
                    try
                    {
                        return File.ReadAllText(metaFile).Contains(guid);
                    }
                    catch (IOException e)
                    {
                        Debug.LogError(e);
                        return false;
                    }
                }).ToArray();
        }
        
        bool ResolveNewGuidReference(string[] referencingAssetPaths, string oldGuid, string oldName, string extension)
        {
            foreach (var potentialNewFile in Directory.EnumerateFiles(Path.GetDirectoryName(assetsFullPath)!, "*" + extension,
                         SearchOption.AllDirectories))
            {
                Debug.Log($"old guid: {oldGuid}");
                var assetPath = Common.FullPathToUnityPath(assetsFullPath, potentialNewFile);
                var newGuid = AssetDatabase.AssetPathToGUID(assetPath);
                Debug.Log($"new guid: {newGuid}");
                if (string.IsNullOrWhiteSpace(newGuid) || Path.GetFileName(potentialNewFile) != oldName || oldGuid == newGuid)
                {
                    continue;
                }
                Debug.Log($"new: {potentialNewFile} | guid: {newGuid}");
                foreach (var path in referencingAssetPaths)
                {
                    var metaFileContents = File.ReadAllText(path).Replace(oldGuid, newGuid);
                    File.WriteAllText(path, metaFileContents);
                }
                
                return true;
            }

            return false;
        }

        void IHasCustomMenu.AddItemsToMenu(GenericMenu menu)
        {
            GUIContent content = new("Open Asset Migrator Repository");
            menu.AddItem(content, false, () => Application.OpenURL(AssetMigratorRepository));
        }

        [MenuItem("Tools/GBMDK/Quick Asset Migrator")]
        public static void ShowWindow()
        {
            GetWindow<QuickAssetMigratorEditor>("Quick Asset Migrator");
        }

        private static string GetWorkingDirectory()
        {
            return
                Path.GetFullPath("Assets/GBMDK/Third-Party/Editor/QuickAssetMigrator");
        }

        private static string[] GetExtensions()
        {
            var extensionOverrides = Path.Combine(GetWorkingDirectory(), "extensions.txt");

            return File.Exists(extensionOverrides)
                ? File.ReadAllLines(extensionOverrides)
                : new[] { "prefab", "unity", "mat", "asset", "controller" };
        }

        private static bool CheckForAssetMigrator()
        {
            var assetMigratorPath = Path.Combine(GetWorkingDirectory(), "asset_migrator.exe");
            return File.Exists(assetMigratorPath);
        }

        private static void MoveDirectoryDestructive(string source, string target)
        {
            if (Directory.Exists(target))
                Directory.Delete(target, true);

            Directory.Move(source, target);
        }

        private static string SplitMigratorArgs(IReadOnlyList<string> args)
        {
            return string.Join(" ", args);
        }

        private static string[] MakeMigrationArgs(string sourceFolder, IReadOnlyList<string> paths)
        {
            // note: asset migrator requires double quotes instead of single quotes, otherwise it'll panic and
            // say the paths are invalid!

            var unityAssetsFolder = assetsFullPath;
            var escapedPaths = paths.Select(path => $"\"{path}\"");

            string[] arguments = { $"\"{sourceFolder}\"", $"\"{unityAssetsFolder}\"" };
            arguments = arguments.Concat(escapedPaths).ToArray();
            Debug.Log(string.Join(" ", arguments));
            return arguments;
        }

        private static bool IsInDirectory(string path, string directory)
        {
            return path.StartsWith(directory);
        }
    }
}