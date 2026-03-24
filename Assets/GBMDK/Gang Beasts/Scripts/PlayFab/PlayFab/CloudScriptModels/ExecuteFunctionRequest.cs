using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ExecuteFunctionRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public string FunctionName;
        public Dictionary<string, string> CustomTags;

        public object FunctionParameter;

        public bool? GeneratePlayStreamEvent;
    }
}