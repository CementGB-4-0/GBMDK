using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetStoreItemsResult : PlayFabResultCommon
    {
        public string CatalogVersion;

        public StoreMarketingModel MarketingData;

        public List<StoreItem> Store;

        public string StoreId;

        public SourceType? Source;
    }
}