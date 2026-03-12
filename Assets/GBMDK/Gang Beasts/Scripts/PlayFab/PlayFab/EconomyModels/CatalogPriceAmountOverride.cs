using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogPriceAmountOverride : PlayFabBaseModel
    {
        public string ItemId;
        public int? FixedValue;

        public double? Multiplier;
    }
}