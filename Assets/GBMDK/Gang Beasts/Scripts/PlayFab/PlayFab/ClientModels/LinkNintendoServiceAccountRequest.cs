using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkNintendoServiceAccountRequest : PlayFabRequestCommon
    {
        public string IdentityToken;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}