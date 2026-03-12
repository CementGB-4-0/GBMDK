using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemResponse : PlayFabResultCommon
    {
        public CatalogItem Item;
    }
}