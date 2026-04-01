using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetDraftItemResponse : PlayFabResultCommon
    {
        public CatalogItem Item;
    }
}