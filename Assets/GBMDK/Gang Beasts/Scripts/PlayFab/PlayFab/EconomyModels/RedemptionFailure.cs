using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedemptionFailure : PlayFabBaseModel
    {
        public string FailureCode;

        public string FailureDetails;

        public string MarketplaceTransactionId;

        public string OfferId;
    }
}