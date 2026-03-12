using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedeemMicrosoftStoreInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public string CollectionsIdKey;

        public EntityKey Entity;

        public string XboxToken;

        public Dictionary<string, string> CustomTags;
    }
}