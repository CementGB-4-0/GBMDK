using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class RegisterQueuedFunctionRequest : PlayFabRequestCommon
    {
        public string ConnectionString;

        public string FunctionName;

        public string QueueName;

        public Dictionary<string, string> CustomTags;
    }
}