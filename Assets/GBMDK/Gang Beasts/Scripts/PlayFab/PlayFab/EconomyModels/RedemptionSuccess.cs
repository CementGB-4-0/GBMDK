using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedemptionSuccess : PlayFabBaseModel
    {
        public string MarketplaceTransactionId;

        public string OfferId;

        public DateTime SuccessTimestamp;
    }
}