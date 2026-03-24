using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class ReportItemReviewRequest : PlayFabRequestCommon
    {
        public CatalogAlternateId AlternateId;

        public EntityKey Entity;

        public string ItemId;

        public string Reason;

        public string ReviewId;

        public ConcernCategory? ConcernCategory;

        public Dictionary<string, string> CustomTags;
    }
}