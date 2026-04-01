using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedeemGooglePlayInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public List<GooglePlayProductPurchase> Purchases;

        public Dictionary<string, string> CustomTags;
    }
}