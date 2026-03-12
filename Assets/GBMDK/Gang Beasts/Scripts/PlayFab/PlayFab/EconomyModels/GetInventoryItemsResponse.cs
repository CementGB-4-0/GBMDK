using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetInventoryItemsResponse : PlayFabResultCommon
    {
        public string ContinuationToken;

        public string ETag;

        public List<InventoryItem> Items;
    }
}