using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetEntityDraftItemsResponse : PlayFabResultCommon
    {
        public string ContinuationToken;

        public List<CatalogItem> Items;
    }
}