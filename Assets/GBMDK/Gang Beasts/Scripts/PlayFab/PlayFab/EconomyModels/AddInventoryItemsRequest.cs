using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class AddInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public string ETag;

        public string IdempotencyId;

        public InventoryItemReference Item;

        public InitialValues NewStackValues;
        public int? Amount;

        public Dictionary<string, string> CustomTags;

        public double? DurationInSeconds;
    }
}