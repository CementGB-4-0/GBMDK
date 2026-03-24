using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class PostFunctionResultForFunctionExecutionRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public ExecuteFunctionResult FunctionResult;
        public Dictionary<string, string> CustomTags;
    }
}