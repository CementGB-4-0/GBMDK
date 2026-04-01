using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UnlockContainerInstanceRequest : PlayFabRequestCommon
    {
        public string CatalogVersion;

        public string CharacterId;

        public string ContainerItemInstanceId;

        public string KeyItemInstanceId;

        public Dictionary<string, string> CustomTags;
    }
}