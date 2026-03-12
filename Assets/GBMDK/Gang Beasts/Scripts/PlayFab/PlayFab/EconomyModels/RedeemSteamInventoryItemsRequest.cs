using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedeemSteamInventoryItemsRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public EntityKey Entity;

        public Dictionary<string, string> CustomTags;
    }
}