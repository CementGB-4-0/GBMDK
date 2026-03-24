using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkAppleRequest : PlayFabRequestCommon
    {
        public string IdentityToken;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}