using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogPriceOptionsOverride : PlayFabBaseModel
    {
        public List<CatalogPriceOverride> Prices;
    }
}