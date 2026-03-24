using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetInventoryCollectionIdsRequest : PlayFabRequestCommon
    {
        public string ContinuationToken;

        public int Count;

        public EntityKey Entity;

        public Dictionary<string, string> CustomTags;
    }
}