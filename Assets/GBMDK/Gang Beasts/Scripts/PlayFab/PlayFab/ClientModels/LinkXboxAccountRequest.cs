using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkXboxAccountRequest : PlayFabRequestCommon
    {
        public string XboxToken;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}