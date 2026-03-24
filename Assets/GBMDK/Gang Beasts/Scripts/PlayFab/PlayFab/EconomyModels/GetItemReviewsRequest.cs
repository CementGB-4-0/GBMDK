using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemReviewsRequest : PlayFabRequestCommon
    {
        public CatalogAlternateId AlternateId;

        public string ContinuationToken;

        public int Count;

        public string Id;

        public string OrderBy;

        public Dictionary<string, string> CustomTags;
    }
}