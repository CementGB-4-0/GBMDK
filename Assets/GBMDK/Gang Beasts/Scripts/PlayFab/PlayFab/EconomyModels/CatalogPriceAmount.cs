using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogPriceAmount : PlayFabBaseModel
    {
        public int Amount;

        public string ItemId;
    }
}