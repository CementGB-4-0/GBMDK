using UnityEditor;

namespace GBMDK.Editor
{
    [FilePath("Exported/GBMDKConfig.asset", FilePathAttribute.Location.PreferencesFolder)]
    public class GBMDKConfigSettings : ScriptableSingleton<GBMDKConfigSettings>
    {
        public const string GBMDKFirstRunKey = "GBMDK_FirstRun";

        public GameSettings gameSettings;

        public static bool IsFirstRun => EditorPrefs.GetBool(GBMDKFirstRunKey, true);

        public new void Save(bool saveAsText = false)
        {
            base.Save(saveAsText);
        }
    }
}