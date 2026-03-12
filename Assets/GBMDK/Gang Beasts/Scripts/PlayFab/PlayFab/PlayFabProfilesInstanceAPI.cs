using System;
using System.Collections.Generic;
using PlayFab.ProfilesModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabProfilesInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabProfilesInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabProfilesInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void GetGlobalPolicy(GetGlobalPolicyRequest request, Action<GetGlobalPolicyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetProfile(GetEntityProfileRequest request, Action<GetEntityProfileResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetProfiles(GetEntityProfilesRequest request, Action<GetEntityProfilesResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitlePlayersFromMasterPlayerAccountIds(GetTitlePlayersFromMasterPlayerAccountIdsRequest request,
            Action<GetTitlePlayersFromMasterPlayerAccountIdsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitlePlayersFromXboxLiveIDs(GetTitlePlayersFromXboxLiveIDsRequest request,
            Action<GetTitlePlayersFromProviderIDsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetGlobalPolicy(SetGlobalPolicyRequest request, Action<SetGlobalPolicyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetProfileLanguage(SetProfileLanguageRequest request,
            Action<SetProfileLanguageResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetProfilePolicy(SetEntityProfilePolicyRequest request,
            Action<SetEntityProfilePolicyResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}