using Costumes;
using GB.Data.Loading;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.SceneManagement;
using UnityEditor.SceneTemplate;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GBMDK.Editor
{
    public class ContentStarters
    {
        private static AddressableAssetEntry MarkAddressable(string assetPath, string assetAddress)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            var entry = settings.CreateOrMoveEntry(AssetDatabase.AssetPathToGUID(assetPath), settings.DefaultGroup);
            entry.SetAddress(assetAddress);

            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
            return entry;
        }
        
        [MenuItem("Assets/GBMDK/Starters/Costume Starter", priority = 10000)] 
        public static void CostumeStarter()
        {
            CreateCostumeStuff();
        }
            
        public static void CreateCostumeStuff(string fallbackPath=null)
        {
            if (!AddressableAssetSettingsDefaultObject.SettingsExists)
                EditorUtility.DisplayDialog("Addressables Nonexistent (Warning)",
                    "Addressables Settings do not exist! You cannot perform this action.", "OK");

            var path = string.IsNullOrWhiteSpace(fallbackPath) ? Common.GetCurrentSelectedAssetPath() : fallbackPath;
            if (path == null) return;
            
            Directory.CreateDirectory(Path.GetFullPath(path));

            var prefabTemplate = PrefabUtility.LoadPrefabContents($"Assets/GBMDK/Prefabs/Templates/CustomContent/HatTemplate.prefab");
            var assetPath = $"{path}/NewCostume.prefab";
            var prefab = PrefabUtility.SaveAsPrefabAssetAndConnect(prefabTemplate, assetPath, InteractionMode.AutomatedAction);
            prefab.name = "NewCostume";
            Object.DestroyImmediate(prefabTemplate);
            EditorUtility.SetDirty(prefab);

            MarkAddressable(assetPath, Path.GetFileNameWithoutExtension(assetPath));

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

            var addrEntryData = MarkAddressable(dataPath, Path.GetFileNameWithoutExtension(dataPath));
            addrEntryData.labels.Add("CostumeItem");

            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = costumeData;
        }

        [MenuItem("Assets/GBMDK/Starters/Map Starter", priority = 10000)]
		public static void MapStarter()
		{
			CreateMapStuff();
		}		

        public static void CreateMapStuff(string fallbackPath=null)
        {
            if (!AddressableAssetSettingsDefaultObject.SettingsExists)
                EditorUtility.DisplayDialog("Addressables Nonexistent (Warning)",
                    "Addressables Settings do not exist! You cannot perform this action.", "OK");
            
            var path = string.IsNullOrWhiteSpace(fallbackPath) ? Common.GetCurrentSelectedAssetPath() : fallbackPath;
            if (path == null) return;
            
            Directory.CreateDirectory(Path.GetFullPath(path));

            var sceneTemplate = AssetDatabase.LoadAssetAtPath<SceneTemplateAsset>("Assets/GBMDK/Scenes/MapTemplate_Template.scenetemplate");
            var scenePath = $"{path}/NewMap.unity";
            var newScene = SceneTemplateService.Instantiate(sceneTemplate, false, scenePath);
            Lightmapping.Bake();
            EditorSceneManager.SaveScene(newScene.scene);

            MarkAddressable(scenePath, Path.GetFileNameWithoutExtension(scenePath));

            var sceneData = ScriptableObject.CreateInstance<SceneData>();
            sceneData.name = "NewMap-Data";
            var dataPath = $"{path}/NewMap-Data.asset";
            typeof(SceneData).GetField("_sceneRef", BindingFlags.NonPublic | BindingFlags.Instance)?.SetValue(sceneData, new AssetReference(AssetDatabase.GUIDFromAssetPath(scenePath).ToString()));
            AssetDatabase.CreateAsset(sceneData, dataPath);
            EditorUtility.SetDirty(sceneData);

            MarkAddressable(dataPath, Path.GetFileNameWithoutExtension(dataPath));

            var sceneInfo = ScriptableObject.CreateInstance<CustomMapInfo>();
            sceneInfo.name = "NewMap-Info";
            var infoPath = $"{path}/NewMap-Info.asset";
            sceneInfo.allowedGamemodes = GB.Gamemodes.GameModeEnum.Melee | GB.Gamemodes.GameModeEnum.Waves;
            AssetDatabase.CreateAsset(sceneInfo, infoPath);
            EditorUtility.SetDirty(sceneInfo);

            EditorUtility.FocusProjectWindow();

            MarkAddressable(infoPath, Path.GetFileNameWithoutExtension(infoPath));

            AssetDatabase.SaveAssets();
            Selection.activeObject = sceneData;
        }
    }
}