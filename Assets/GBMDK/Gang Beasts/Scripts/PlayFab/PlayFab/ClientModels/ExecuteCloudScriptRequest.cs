using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ExecuteCloudScriptRequest : PlayFabRequestCommon
    {
        public string FunctionName;
        public Dictionary<string, string> CustomTags;

        public object FunctionParameter;

        public bool? GeneratePlayStreamEvent;

        public CloudScriptRevisionOption? RevisionSelection;

        public int? SpecificRevision;
    }
}