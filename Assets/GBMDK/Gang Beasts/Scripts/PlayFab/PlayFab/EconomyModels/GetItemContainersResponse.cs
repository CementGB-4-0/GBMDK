using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemContainersResponse : PlayFabResultCommon
    {
        public List<CatalogItem> Containers;

        public string ContinuationToken;
    }
}