using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class GetFunctionRequest : PlayFabRequestCommon
    {
        public string FunctionName;
        public Dictionary<string, string> CustomTags;
    }
}