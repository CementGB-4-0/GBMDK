using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetMicrosoftStoreAccessTokensRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}