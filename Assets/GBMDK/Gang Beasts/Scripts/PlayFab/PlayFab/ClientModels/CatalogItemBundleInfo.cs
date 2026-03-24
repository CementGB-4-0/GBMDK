using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CatalogItemBundleInfo : PlayFabBaseModel
    {
        public List<string> BundledItems;

        public List<string> BundledResultTables;

        public Dictionary<string, uint> BundledVirtualCurrencies;
    }
}