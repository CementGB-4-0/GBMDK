using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ConsumeXboxEntitlementsRequest : PlayFabRequestCommon
    {
        public string CatalogVersion;

        public string XboxToken;

        public Dictionary<string, string> CustomTags;
    }
}