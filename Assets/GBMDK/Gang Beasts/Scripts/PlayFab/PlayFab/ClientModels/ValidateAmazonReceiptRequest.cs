using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ValidateAmazonReceiptRequest : PlayFabRequestCommon
    {
        public string CatalogVersion;

        public string CurrencyCode;

        public int PurchasePrice;

        public string ReceiptId;

        public string UserId;

        public Dictionary<string, string> CustomTags;
    }
}