using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class UpdateDraftItemResponse : PlayFabResultCommon
    {
        public CatalogItem Item;
    }
}