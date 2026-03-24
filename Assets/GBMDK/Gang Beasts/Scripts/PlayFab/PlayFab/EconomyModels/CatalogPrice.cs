using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogPrice : PlayFabBaseModel
    {
        public List<CatalogPriceAmount> Amounts;

        public double? UnitDurationInSeconds;
    }
}