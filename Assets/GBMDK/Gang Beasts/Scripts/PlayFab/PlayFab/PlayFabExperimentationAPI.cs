using System;
using System.Collections.Generic;
using PlayFab.ExperimentationModels;

namespace PlayFab
{
    public static class PlayFabExperimentationAPI
    {
        static PlayFabExperimentationAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void CreateExclusionGroup(CreateExclusionGroupRequest request,
            Action<CreateExclusionGroupResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateExperiment(CreateExperimentRequest request,
            Action<CreateExperimentResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteExclusionGroup(DeleteExclusionGroupRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteExperiment(DeleteExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetExclusionGroups(GetExclusionGroupsRequest request,
            Action<GetExclusionGroupsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetExclusionGroupTraffic(GetExclusionGroupTrafficRequest request,
            Action<GetExclusionGroupTrafficResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetExperiments(GetExperimentsRequest request, Action<GetExperimentsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetLatestScorecard(GetLatestScorecardRequest request,
            Action<GetLatestScorecardResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTreatmentAssignment(GetTreatmentAssignmentRequest request,
            Action<GetTreatmentAssignmentResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void StartExperiment(StartExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void StopExperiment(StopExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateExclusionGroup(UpdateExclusionGroupRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateExperiment(UpdateExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}