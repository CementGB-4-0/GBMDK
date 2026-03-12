using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class DeleteInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public string ETag;

        public string IdempotencyId;

        public InventoryItemReference Item;

        public Dictionary<string, string> CustomTags;
    }
}