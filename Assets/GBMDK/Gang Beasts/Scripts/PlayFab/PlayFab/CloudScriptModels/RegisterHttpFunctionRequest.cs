using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class RegisterHttpFunctionRequest : PlayFabRequestCommon
    {
        public string FunctionName;

        public string FunctionUrl;
        public Dictionary<string, string> CustomTags;
    }
}