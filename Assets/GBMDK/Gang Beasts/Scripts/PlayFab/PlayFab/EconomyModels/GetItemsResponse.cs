using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemsResponse : PlayFabResultCommon
    {
        public List<CatalogItem> Items;
    }
}