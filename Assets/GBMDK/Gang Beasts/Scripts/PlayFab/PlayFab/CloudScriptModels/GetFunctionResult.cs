using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class GetFunctionResult : PlayFabResultCommon
    {
        public string ConnectionString;

        public string FunctionUrl;

        public string QueueName;

        public string TriggerType;
    }
}