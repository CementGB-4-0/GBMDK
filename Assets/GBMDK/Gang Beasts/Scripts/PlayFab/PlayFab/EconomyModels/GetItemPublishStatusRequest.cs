using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemPublishStatusRequest : PlayFabRequestCommon
    {
        public CatalogAlternateId AlternateId;

        public EntityKey Entity;

        public string Id;

        public Dictionary<string, string> CustomTags;
    }
}