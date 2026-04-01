using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemReviewsResponse : PlayFabResultCommon
    {
        public string ContinuationToken;

        public List<Review> Reviews;
    }
}