using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PurchaseReceiptFulfillment : PlayFabBaseModel
    {
        public List<ItemInstance> FulfilledItems;

        public string RecordedPriceSource;

        public string RecordedTransactionCurrency;

        public uint? RecordedTransactionTotal;
    }
}