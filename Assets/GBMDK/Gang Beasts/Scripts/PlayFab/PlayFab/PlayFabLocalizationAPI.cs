using System;
using System.Collections.Generic;
using PlayFab.LocalizationModels;

namespace PlayFab
{
    public static class PlayFabLocalizationAPI
    {
        static PlayFabLocalizationAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void GetLanguageList(GetLanguageListRequest request,
            Action<GetLanguageListResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}