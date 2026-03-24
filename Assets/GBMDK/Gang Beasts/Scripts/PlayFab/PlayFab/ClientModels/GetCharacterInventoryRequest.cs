using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetCharacterInventoryRequest : PlayFabRequestCommon
    {
        public string CatalogVersion;

        public string CharacterId;

        public Dictionary<string, string> CustomTags;
    }
}