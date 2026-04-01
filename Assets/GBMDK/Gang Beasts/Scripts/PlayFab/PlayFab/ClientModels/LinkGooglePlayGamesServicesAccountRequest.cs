using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkGooglePlayGamesServicesAccountRequest : PlayFabRequestCommon
    {
        public string ServerAuthCode;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}