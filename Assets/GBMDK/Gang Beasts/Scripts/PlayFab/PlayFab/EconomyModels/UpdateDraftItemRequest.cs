using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class UpdateDraftItemRequest : PlayFabRequestCommon
    {
        public CatalogItem Item;

        public bool Publish;
        public Dictionary<string, string> CustomTags;
    }
}