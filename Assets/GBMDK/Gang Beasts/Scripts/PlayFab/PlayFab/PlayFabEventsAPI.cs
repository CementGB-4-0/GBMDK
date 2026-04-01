using System;
using System.Collections.Generic;
using PlayFab.EventsModels;

namespace PlayFab
{
    public static class PlayFabEventsAPI
    {
        static PlayFabEventsAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void WriteEvents(WriteEventsRequest request, Action<WriteEventsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void WriteTelemetryEvents(WriteEventsRequest request, Action<WriteEventsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}