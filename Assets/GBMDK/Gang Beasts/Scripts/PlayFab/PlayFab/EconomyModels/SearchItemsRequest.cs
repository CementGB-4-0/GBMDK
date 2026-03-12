using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class SearchItemsRequest : PlayFabRequestCommon
    {
        public string ContinuationToken;

        public int Count;

        public EntityKey Entity;

        public string Filter;

        public string OrderBy;

        public string Search;

        public string Select;

        public StoreReference Store;

        public Dictionary<string, string> CustomTags;
    }
}