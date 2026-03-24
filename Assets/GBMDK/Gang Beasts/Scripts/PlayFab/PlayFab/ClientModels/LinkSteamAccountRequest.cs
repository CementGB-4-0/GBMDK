using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkSteamAccountRequest : PlayFabRequestCommon
    {
        public string SteamTicket;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}