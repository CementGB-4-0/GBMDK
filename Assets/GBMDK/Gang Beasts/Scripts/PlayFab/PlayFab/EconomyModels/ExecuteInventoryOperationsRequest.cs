using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class ExecuteInventoryOperationsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public string ETag;

        public string IdempotencyId;

        public List<InventoryOperation> Operations;

        public Dictionary<string, string> CustomTags;
    }
}