using System;
using System.Collections.Generic;
using PlayFab.EventsModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabEventsInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabEventsInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabEventsInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void WriteEvents(WriteEventsRequest request, Action<WriteEventsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void WriteTelemetryEvents(WriteEventsRequest request, Action<WriteEventsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}