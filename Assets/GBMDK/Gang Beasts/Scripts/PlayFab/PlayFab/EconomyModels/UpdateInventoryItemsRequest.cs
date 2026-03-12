using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class UpdateInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public string ETag;

        public string IdempotencyId;

        public InventoryItem Item;

        public Dictionary<string, string> CustomTags;
    }
}