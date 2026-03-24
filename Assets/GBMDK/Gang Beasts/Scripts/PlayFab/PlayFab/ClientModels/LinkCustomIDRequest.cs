using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkCustomIDRequest : PlayFabRequestCommon
    {
        public string CustomId;

        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}