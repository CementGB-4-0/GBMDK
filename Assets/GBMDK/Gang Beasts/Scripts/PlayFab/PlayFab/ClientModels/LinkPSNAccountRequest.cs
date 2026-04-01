using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkPSNAccountRequest : PlayFabRequestCommon
    {
        public string AuthCode;

        public string RedirectUri;

        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;

        public int? IssuerId;
    }
}