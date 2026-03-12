using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetDraftItemsRequest : PlayFabRequestCommon
    {
        public List<CatalogAlternateId> AlternateIds;

        public EntityKey Entity;

        public List<string> Ids;

        public Dictionary<string, string> CustomTags;
    }
}