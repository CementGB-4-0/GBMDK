using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class SearchItemsResponse : PlayFabResultCommon
    {
        public string ContinuationToken;

        public List<CatalogItem> Items;
    }
}