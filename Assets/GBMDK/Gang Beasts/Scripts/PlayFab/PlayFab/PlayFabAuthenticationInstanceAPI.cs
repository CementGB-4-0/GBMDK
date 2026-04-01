using System;
using System.Collections.Generic;
using PlayFab.AuthenticationModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabAuthenticationInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabAuthenticationInstanceAPI()
        {
        }

        public PlayFabAuthenticationInstanceAPI(PlayFabApiSettings settings)
        {
        }

        public PlayFabAuthenticationInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabAuthenticationInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void AuthenticateGameServerWithCustomId(AuthenticateCustomIdRequest request,
            Action<AuthenticateCustomIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void Delete(DeleteRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetEntityToken(GetEntityTokenRequest request, Action<GetEntityTokenResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ValidateEntityToken(ValidateEntityTokenRequest request,
            Action<ValidateEntityTokenResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}