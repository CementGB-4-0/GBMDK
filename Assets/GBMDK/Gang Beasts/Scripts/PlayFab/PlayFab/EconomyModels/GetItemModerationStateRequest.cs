using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemModerationStateRequest : PlayFabRequestCommon
    {
        public CatalogAlternateId AlternateId;

        public string Id;

        public Dictionary<string, string> CustomTags;
    }
}