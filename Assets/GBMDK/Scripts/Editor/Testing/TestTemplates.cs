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
            var prevModName = GBMDKConfigSettings.ActiveModName;
            GBMDKConfigSettings.ActiveModName = TemplateModName;
            AddressableAssetSettingsDefaultObject.Settings.ShaderBundleCustomNaming = $"{TemplateModName}";
            ModTester.TestMod();
            GBMDKConfigSettings.ActiveModName = prevModName;
            AddressableAssetSettingsDefaultObject.Settings.ShaderBundleCustomNaming = $"{prevModName}";
            AssetDatabase.DeleteAsset($"Assets/Mods/{TemplateModName}");
        }
    }
}