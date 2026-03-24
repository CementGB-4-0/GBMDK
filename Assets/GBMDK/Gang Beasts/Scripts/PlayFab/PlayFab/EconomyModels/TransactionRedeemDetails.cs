using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class TransactionRedeemDetails : PlayFabBaseModel
    {
        public string Marketplace;

        public string MarketplaceTransactionId;

        public string OfferId;
    }
}