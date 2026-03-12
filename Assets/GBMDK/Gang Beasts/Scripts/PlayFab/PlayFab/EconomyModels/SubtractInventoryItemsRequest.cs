using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class SubtractInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public bool DeleteEmptyStacks;

        public EntityKey Entity;

        public string ETag;

        public string IdempotencyId;

        public InventoryItemReference Item;
        public int? Amount;

        public Dictionary<string, string> CustomTags;

        public double? DurationInSeconds;
    }
}