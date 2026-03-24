using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogPriceOptions : PlayFabBaseModel
    {
        public List<CatalogPrice> Prices;
    }
}