using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ItemInstance : PlayFabBaseModel
    {
        public string Annotation;

        public List<string> BundleContents;

        public string BundleParent;

        public string CatalogVersion;

        public string DisplayName;

        public string ItemClass;

        public string ItemId;

        public string ItemInstanceId;

        public string UnitCurrency;

        public uint UnitPrice;

        public Dictionary<string, string> CustomData;

        public DateTime? Expiration;

        public DateTime? PurchaseDate;

        public int? RemainingUses;

        public int? UsesIncrementedBy;
    }
}