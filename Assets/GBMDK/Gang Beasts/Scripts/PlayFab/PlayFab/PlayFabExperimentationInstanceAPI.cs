using System;
using System.Collections.Generic;
using PlayFab.ExperimentationModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabExperimentationInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabExperimentationInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabExperimentationInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void CreateExclusionGroup(CreateExclusionGroupRequest request,
            Action<CreateExclusionGroupResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateExperiment(CreateExperimentRequest request, Action<CreateExperimentResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteExclusionGroup(DeleteExclusionGroupRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteExperiment(DeleteExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetExclusionGroups(GetExclusionGroupsRequest request,
            Action<GetExclusionGroupsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetExclusionGroupTraffic(GetExclusionGroupTrafficRequest request,
            Action<GetExclusionGroupTrafficResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetExperiments(GetExperimentsRequest request, Action<GetExperimentsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetLatestScorecard(GetLatestScorecardRequest request,
            Action<GetLatestScorecardResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTreatmentAssignment(GetTreatmentAssignmentRequest request,
            Action<GetTreatmentAssignmentResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void StartExperiment(StartExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void StopExperiment(StopExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateExclusionGroup(UpdateExclusionGroupRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateExperiment(UpdateExperimentRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}