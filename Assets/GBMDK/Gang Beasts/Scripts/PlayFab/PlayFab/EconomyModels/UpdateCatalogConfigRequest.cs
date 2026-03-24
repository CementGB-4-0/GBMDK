using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class UpdateCatalogConfigRequest : PlayFabRequestCommon
    {
        public CatalogConfig Config;

        public Dictionary<string, string> CustomTags;
    }
}