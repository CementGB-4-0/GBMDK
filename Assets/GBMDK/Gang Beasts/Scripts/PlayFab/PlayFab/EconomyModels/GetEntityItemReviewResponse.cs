using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetEntityItemReviewResponse : PlayFabResultCommon
    {
        public Review Review;
    }
}