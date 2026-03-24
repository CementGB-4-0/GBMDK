using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class SubmitItemReviewVoteRequest : PlayFabRequestCommon
    {
        public CatalogAlternateId AlternateId;

        public EntityKey Entity;

        public string ItemId;

        public string ReviewId;

        public Dictionary<string, string> CustomTags;

        public HelpfulnessVote? Vote;
    }
}