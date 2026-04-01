using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CatalogItem : PlayFabBaseModel
    {
        public CatalogItemBundleInfo Bundle;

        public bool CanBecomeCharacter;

        public string CatalogVersion;

        public CatalogItemConsumableInfo Consumable;

        public CatalogItemContainerInfo Container;

        public string CustomData;

        public string Description;

        public string DisplayName;

        public int InitialLimitedEditionCount;

        public bool IsLimitedEdition;

        public bool IsStackable;

        public bool IsTradable;

        public string ItemClass;

        public string ItemId;

        public string ItemImageUrl;

        public List<string> Tags;

        public Dictionary<string, uint> RealCurrencyPrices;

        public Dictionary<string, uint> VirtualCurrencyPrices;
    }
}