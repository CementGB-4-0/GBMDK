using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemContainersRequest : PlayFabRequestCommon
    {
        public CatalogAlternateId AlternateId;

        public string ContinuationToken;

        public int Count;

        public EntityKey Entity;

        public string Id;

        public Dictionary<string, string> CustomTags;
    }
}