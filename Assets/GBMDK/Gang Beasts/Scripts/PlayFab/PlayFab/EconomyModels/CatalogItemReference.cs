using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogItemReference : PlayFabBaseModel
    {
        public string Id;

        public CatalogPriceOptions PriceOptions;
        public int? Amount;
    }
}