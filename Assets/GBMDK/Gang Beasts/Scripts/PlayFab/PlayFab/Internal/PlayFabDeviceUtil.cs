using PlayFab.ClientModels;
using PlayFab.SharedModels;

namespace PlayFab.Internal
{
    public static class PlayFabDeviceUtil
    {
        private static bool _needsAttribution;

        private static bool _gatherDeviceInfo;

        private static bool _gatherScreenTime;

        private static void SendDeviceInfoToPlayFab(PlayFabApiSettings settings, IPlayFabInstanceApi instanceApi)
        {
        }

        private static void OnGatherFail(PlayFabError error)
        {
        }

        public static void OnPlayFabLogin(PlayFabResultCommon result, PlayFabApiSettings settings,
            IPlayFabInstanceApi instanceApi)
        {
        }

        private static void _OnPlayFabLogin(UserSettings settingsForUser, string playFabId, string entityId,
            string entityType, PlayFabApiSettings settings, IPlayFabInstanceApi instanceApi)
        {
        }
    }
}