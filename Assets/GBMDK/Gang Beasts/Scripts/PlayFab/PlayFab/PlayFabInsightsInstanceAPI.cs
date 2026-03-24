using System;
using System.Collections.Generic;
using PlayFab.InsightsModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabInsightsInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabInsightsInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabInsightsInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void GetDetails(InsightsEmptyRequest request, Action<InsightsGetDetailsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetLimits(InsightsEmptyRequest request, Action<InsightsGetLimitsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetOperationStatus(InsightsGetOperationStatusRequest request,
            Action<InsightsGetOperationStatusResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPendingOperations(InsightsGetPendingOperationsRequest request,
            Action<InsightsGetPendingOperationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetPerformance(InsightsSetPerformanceRequest request,
            Action<InsightsOperationResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetStorageRetention(InsightsSetStorageRetentionRequest request,
            Action<InsightsOperationResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}