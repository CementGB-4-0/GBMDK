using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetInventoryCollectionIdsResponse : PlayFabResultCommon
    {
        public List<string> CollectionIds;

        public string ContinuationToken;
    }
}