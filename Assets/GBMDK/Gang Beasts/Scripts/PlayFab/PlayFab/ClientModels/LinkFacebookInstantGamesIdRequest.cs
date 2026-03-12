using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkFacebookInstantGamesIdRequest : PlayFabRequestCommon
    {
        public string FacebookInstantGamesSignature;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}