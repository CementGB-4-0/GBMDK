using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogPriceOverride : PlayFabBaseModel
    {
        public List<CatalogPriceAmountOverride> Amounts;
    }
}