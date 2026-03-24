using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class UnregisterFunctionRequest : PlayFabRequestCommon
    {
        public string FunctionName;
        public Dictionary<string, string> CustomTags;
    }
}