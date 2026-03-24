using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemReviewSummaryResponse : PlayFabResultCommon
    {
        public Review LeastFavorableReview;

        public Review MostFavorableReview;

        public Rating Rating;

        public int ReviewsCount;
    }
}