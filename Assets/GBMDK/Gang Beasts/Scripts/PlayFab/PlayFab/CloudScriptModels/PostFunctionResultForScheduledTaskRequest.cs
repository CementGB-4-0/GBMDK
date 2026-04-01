using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class PostFunctionResultForScheduledTaskRequest : PlayFabRequestCommon
    {
        public ExecuteFunctionResult FunctionResult;

        public NameIdentifier ScheduledTaskId;
        public Dictionary<string, string> CustomTags;
    }
}