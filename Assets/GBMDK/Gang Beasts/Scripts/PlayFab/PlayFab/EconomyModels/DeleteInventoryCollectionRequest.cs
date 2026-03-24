using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class DeleteInventoryCollectionRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public string ETag;

        public Dictionary<string, string> CustomTags;
    }
}