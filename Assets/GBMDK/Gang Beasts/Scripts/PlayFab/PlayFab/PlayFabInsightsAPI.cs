using System;
using System.Collections.Generic;
using PlayFab.InsightsModels;

namespace PlayFab
{
    public static class PlayFabInsightsAPI
    {
        static PlayFabInsightsAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void GetDetails(InsightsEmptyRequest request, Action<InsightsGetDetailsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetLimits(InsightsEmptyRequest request, Action<InsightsGetLimitsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetOperationStatus(InsightsGetOperationStatusRequest request,
            Action<InsightsGetOperationStatusResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPendingOperations(InsightsGetPendingOperationsRequest request,
            Action<InsightsGetPendingOperationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetPerformance(InsightsSetPerformanceRequest request,
            Action<InsightsOperationResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetStorageRetention(InsightsSetStorageRetentionRequest request,
            Action<InsightsOperationResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}