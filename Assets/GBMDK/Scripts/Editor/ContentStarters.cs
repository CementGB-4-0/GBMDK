using System.IO;
using System.Reflection;
using Costumes;
using GB.Data.Loading;
using GB.Gamemodes;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.SceneManagement;
using UnityEditor.SceneTemplate;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GBMDK.Editor
{
    public class ContentStarters
    {
        public static void CreateCostumeStuff(string fallbackPath = null, string entryName = "NewCostume")
        {
            var path = string.IsNullOrWhiteSpace(fallbackPath) ? Common.GetCurrentSelectedAssetPath() : fallbackPath;
            if (path == null) return;

            Directory.CreateDirectory(Path.GetFullPath(path));

            var prefabTemplate =
                PrefabUtility.LoadPrefabContents("Assets/GBMDK/Prefabs/Templates/CustomContent/HatTemplate.prefab");
            var assetPath = $"{path}/{entryName}.prefab";
            var prefab =
                PrefabUtility.SaveAsPrefabAssetAndConnect(prefabTemplate, assetPath, InteractionMode.AutomatedAction);
            prefab.name = entryName;
            Object.DestroyImmediate(prefabTemplate);
            EditorUtility.SetDirty(prefab);

            Common.MarkAddressable(assetPath, Path.GetFileNameWithoutExtension(assetPath));

            var costumeData = ScriptableObject.CreateInstance<CostumeObject>();
            costumeData.name = $"{prefab.name}-Data";
            costumeData.PrimaryPart = CostumeParts.Head;
            costumeData.Unlocked = true;
            costumeData.Enabled = true;
            costumeData.CostumeItems = new AssetReferenceGameObject[]
            {
                new(AssetDatabase.GUIDFromAssetPath(assetPath).ToString())
            };
            var dataPath = $"{path}/{costumeData.name}.asset";
            AssetDatabase.CreateAsset(costumeData, dataPath);
            EditorUtility.SetDirty(costumeData);

            var addrEntryData = Common.MarkAddressable(dataPath, Path.GetFileNameWithoutExtension(dataPath));
            addrEntryData.labels.Add("Costume");

            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = costumeData;
        }

        public static void CreateMapStuff(string fallbackPath = null, string entryName = "NewMap")
        {
            if (!AddressableAssetSettingsDefaultObject.SettingsExists)
                EditorUtility.DisplayDialog("Addressables Nonexistent (Warning)",
                    "Addressables Settings do not exist! You cannot perform this action.", "OK");

            var path = string.IsNullOrWhiteSpace(fallbackPath) ? Common.GetCurrentSelectedAssetPath() : fallbackPath;
            if (path == null) return;

            Directory.CreateDirectory(Path.GetFullPath(path));

            var sceneTemplate =
                AssetDatabase.LoadAssetAtPath<SceneTemplateAsset>(
                    "Assets/GBMDK/Scenes/MapTemplate_Template.scenetemplate");
            var scenePath = $"{path}/{entryName}.unity";
            var newScene = SceneTemplateService.Instantiate(sceneTemplate, false, scenePath);
            EditorSceneManager.SaveScene(newScene.scene);

            Common.MarkAddressable(scenePath, Path.GetFileNameWithoutExtension(scenePath));

            var sceneData = ScriptableObject.CreateInstance<SceneData>();
            sceneData.name = $"{entryName}-Data";
            var dataPath = $"{path}/{entryName}-Data.asset";
            typeof(SceneData).GetField("_sceneRef", BindingFlags.NonPublic | BindingFlags.Instance)?.SetValue(sceneData,
                new AssetReference(AssetDatabase.GUIDFromAssetPath(scenePath).ToString()));
            AssetDatabase.CreateAsset(sceneData, dataPath);
            EditorUtility.SetDirty(sceneData);

            Common.MarkAddressable(dataPath, Path.GetFileNameWithoutExtension(dataPath));

            var sceneInfo = ScriptableObject.CreateInstance<CustomMapInfo>();
            sceneInfo.name = $"{entryName}-Info";
            var infoPath = $"{path}/{entryName}-Info.asset";
            sceneInfo.allowedGamemodes = GameModeEnum.Melee;
            AssetDatabase.CreateAsset(sceneInfo, infoPath);
            EditorUtility.SetDirty(sceneInfo);

            EditorUtility.FocusProjectWindow();

            Common.MarkAddressable(infoPath, Path.GetFileNameWithoutExtension(infoPath));

            AssetDatabase.Refresh();
            Selection.activeObject = sceneData;
        }
    }
}