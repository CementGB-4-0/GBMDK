using System;
using System.Collections.Generic;
using PlayFab.LocalizationModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabLocalizationInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabLocalizationInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabLocalizationInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void GetLanguageList(GetLanguageListRequest request, Action<GetLanguageListResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}