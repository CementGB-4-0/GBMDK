using System;
using System.Collections.Generic;
using PlayFab.CloudScriptModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabCloudScriptInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabCloudScriptInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabCloudScriptInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void ExecuteEntityCloudScript(ExecuteEntityCloudScriptRequest request,
            Action<ExecuteCloudScriptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ExecuteFunction(ExecuteFunctionRequest request, Action<ExecuteFunctionResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetFunction(GetFunctionRequest request, Action<GetFunctionResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListFunctions(ListFunctionsRequest request, Action<ListFunctionsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListHttpFunctions(ListFunctionsRequest request, Action<ListHttpFunctionsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListQueuedFunctions(ListFunctionsRequest request, Action<ListQueuedFunctionsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PostFunctionResultForEntityTriggeredAction(
            PostFunctionResultForEntityTriggeredActionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PostFunctionResultForFunctionExecution(PostFunctionResultForFunctionExecutionRequest request,
            Action<EmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PostFunctionResultForPlayerTriggeredAction(
            PostFunctionResultForPlayerTriggeredActionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PostFunctionResultForScheduledTask(PostFunctionResultForScheduledTaskRequest request,
            Action<EmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RegisterHttpFunction(RegisterHttpFunctionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RegisterQueuedFunction(RegisterQueuedFunctionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnregisterFunction(UnregisterFunctionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}