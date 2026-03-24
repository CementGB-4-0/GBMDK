using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ScriptExecutionError : PlayFabBaseModel
    {
        public string Error;

        public string Message;

        public string StackTrace;
    }
}