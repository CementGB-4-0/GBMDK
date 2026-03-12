using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class QueuedFunctionModel : PlayFabBaseModel
    {
        public string ConnectionString;

        public string FunctionName;

        public string QueueName;
    }
}