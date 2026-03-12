using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class PurchaseInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public bool DeleteEmptyStacks;

        public EntityKey Entity;

        public string ETag;

        public string IdempotencyId;

        public InventoryItemReference Item;

        public InitialValues NewStackValues;

        public List<PurchasePriceAmount> PriceAmounts;

        public string StoreId;
        public int? Amount;

        public Dictionary<string, string> CustomTags;

        public double? DurationInSeconds;
    }
}