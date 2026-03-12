using System;
using System.Collections.Generic;
using PlayFab.CloudScriptModels;

namespace PlayFab
{
    public static class PlayFabCloudScriptAPI
    {
        static PlayFabCloudScriptAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void ExecuteEntityCloudScript(ExecuteEntityCloudScriptRequest request,
            Action<ExecuteCloudScriptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ExecuteFunction(ExecuteFunctionRequest request, Action<ExecuteFunctionResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetFunction(GetFunctionRequest request, Action<GetFunctionResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListFunctions(ListFunctionsRequest request, Action<ListFunctionsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListHttpFunctions(ListFunctionsRequest request,
            Action<ListHttpFunctionsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListQueuedFunctions(ListFunctionsRequest request,
            Action<ListQueuedFunctionsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PostFunctionResultForEntityTriggeredAction(
            PostFunctionResultForEntityTriggeredActionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PostFunctionResultForFunctionExecution(PostFunctionResultForFunctionExecutionRequest request,
            Action<EmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PostFunctionResultForPlayerTriggeredAction(
            PostFunctionResultForPlayerTriggeredActionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PostFunctionResultForScheduledTask(PostFunctionResultForScheduledTaskRequest request,
            Action<EmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RegisterHttpFunction(RegisterHttpFunctionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RegisterQueuedFunction(RegisterQueuedFunctionRequest request,
            Action<EmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnregisterFunction(UnregisterFunctionRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}