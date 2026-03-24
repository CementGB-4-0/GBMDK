using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class RestoreIOSPurchasesRequest : PlayFabRequestCommon
    {
        public string CatalogVersion;

        public string ReceiptData;

        public Dictionary<string, string> CustomTags;
    }
}