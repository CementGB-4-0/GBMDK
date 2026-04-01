using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UnlinkFacebookInstantGamesIdRequest : PlayFabRequestCommon
    {
        public string FacebookInstantGamesId;
        public Dictionary<string, string> CustomTags;
    }
}