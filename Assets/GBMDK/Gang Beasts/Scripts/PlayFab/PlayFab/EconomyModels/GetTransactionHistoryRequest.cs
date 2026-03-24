using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetTransactionHistoryRequest : PlayFabRequestCommon
    {
        public string CollectionId;

        public string ContinuationToken;

        public int Count;

        public EntityKey Entity;

        public string Filter;

        public Dictionary<string, string> CustomTags;
    }
}