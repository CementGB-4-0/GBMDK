using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ListFunctionsRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}