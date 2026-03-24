using System;
using System.Collections.Generic;
using PlayFab.AuthenticationModels;

namespace PlayFab
{
    public static class PlayFabAuthenticationAPI
    {
        static PlayFabAuthenticationAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void AuthenticateGameServerWithCustomId(AuthenticateCustomIdRequest request,
            Action<AuthenticateCustomIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void Delete(DeleteRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetEntityToken(GetEntityTokenRequest request, Action<GetEntityTokenResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ValidateEntityToken(ValidateEntityTokenRequest request,
            Action<ValidateEntityTokenResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}