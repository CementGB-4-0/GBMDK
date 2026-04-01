using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class FunctionExecutionError : PlayFabBaseModel
    {
        public string Error;

        public string Message;

        public string StackTrace;
    }
}