using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkGoogleAccountRequest : PlayFabRequestCommon
    {
        public string ServerAuthCode;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}