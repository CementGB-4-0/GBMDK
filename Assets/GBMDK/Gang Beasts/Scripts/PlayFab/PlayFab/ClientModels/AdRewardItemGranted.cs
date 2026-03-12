using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class AdRewardItemGranted : PlayFabBaseModel
    {
        public string CatalogId;

        public string DisplayName;

        public string InstanceId;

        public string ItemId;
    }
}