using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UnlockContainerItemRequest : PlayFabRequestCommon
    {
        public string CatalogVersion;

        public string CharacterId;

        public string ContainerItemId;

        public Dictionary<string, string> CustomTags;
    }
}