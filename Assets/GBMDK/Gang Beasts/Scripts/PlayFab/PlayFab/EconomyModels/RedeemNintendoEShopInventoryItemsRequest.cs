using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedeemNintendoEShopInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public string NintendoServiceAccountIdToken;

        public Dictionary<string, string> CustomTags;
    }
}