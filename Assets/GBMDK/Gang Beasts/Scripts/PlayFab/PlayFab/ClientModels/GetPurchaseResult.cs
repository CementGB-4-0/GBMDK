using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPurchaseResult : PlayFabResultCommon
    {
        public string OrderId;

        public string PaymentProvider;

        public string TransactionId;

        public string TransactionStatus;

        public DateTime PurchaseDate;
    }
}