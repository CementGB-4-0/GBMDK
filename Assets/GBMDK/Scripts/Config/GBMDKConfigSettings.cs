#if UNITY_EDITOR

using UnityEditor;
using UnityEditor.AddressableAssets;

namespace GBMDK.Editor
{
    [FilePath("Exported/GBMDKConfig.asset", FilePathAttribute.Location.PreferencesFolder)]
    public class GBMDKConfigSettings : ScriptableSingleton<GBMDKConfigSettings>
    {
        public const string GBMDKFirstRunKey = "GBMDK_FirstRun";

        public GameSettings gameSettings;

        public static string ActiveModName
        {
            get =>
                AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(
                    AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName");
            set =>
                AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                    AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName", value);
        }

        public static bool IsFirstRun => EditorPrefs.GetBool(GBMDKFirstRunKey, true);

        public new void Save(bool saveAsText = false)
        {
            base.Save(saveAsText);
        }
    }
}

#endif