using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedeemPlayStationStoreInventoryItemsRequest : PlayFabRequestCommon
    {
        public string AuthorizationCode;

        public string CollectionId;

        public EntityKey Entity;

        public string RedirectUri;

        public string ServiceLabel;

        public Dictionary<string, string> CustomTags;
    }
}