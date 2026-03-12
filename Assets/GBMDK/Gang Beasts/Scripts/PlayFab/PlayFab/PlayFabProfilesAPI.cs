using System;
using System.Collections.Generic;
using PlayFab.ProfilesModels;

namespace PlayFab
{
    public static class PlayFabProfilesAPI
    {
        static PlayFabProfilesAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void GetGlobalPolicy(GetGlobalPolicyRequest request,
            Action<GetGlobalPolicyResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetProfile(GetEntityProfileRequest request, Action<GetEntityProfileResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetProfiles(GetEntityProfilesRequest request,
            Action<GetEntityProfilesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitlePlayersFromMasterPlayerAccountIds(
            GetTitlePlayersFromMasterPlayerAccountIdsRequest request,
            Action<GetTitlePlayersFromMasterPlayerAccountIdsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitlePlayersFromXboxLiveIDs(GetTitlePlayersFromXboxLiveIDsRequest request,
            Action<GetTitlePlayersFromProviderIDsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetGlobalPolicy(SetGlobalPolicyRequest request,
            Action<SetGlobalPolicyResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetProfileLanguage(SetProfileLanguageRequest request,
            Action<SetProfileLanguageResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetProfilePolicy(SetEntityProfilePolicyRequest request,
            Action<SetEntityProfilePolicyResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}