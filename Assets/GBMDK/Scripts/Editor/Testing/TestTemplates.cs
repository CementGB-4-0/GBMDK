using UnityEditor;
using UnityEditor.AddressableAssets;

namespace GBMDK.Editor
{
    public static class TestTemplates
    {
        public const string TemplateModName = "GBMDKTemplatesMod";

        [MenuItem("GBMDK/Testing/Test GBMDK Templates")]
        public static void Test()
        {
            ContentStarters.CreateMapStuff($"Assets/Mods/{TemplateModName}/Maps/NewMap");
            ContentStarters.CreateCostumeStuff($"Assets/Mods/{TemplateModName}/Costumes/NewCostume");
            var prevModName = AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName");
            AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName", $"{TemplateModName}");
            ModTester.TestMod();
            AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName", prevModName);
            AssetDatabase.DeleteAsset($"Assets/Mods/{TemplateModName}");
        }
    }
}