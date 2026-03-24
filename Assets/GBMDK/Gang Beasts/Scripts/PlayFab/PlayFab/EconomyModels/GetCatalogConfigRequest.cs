using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetCatalogConfigRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}