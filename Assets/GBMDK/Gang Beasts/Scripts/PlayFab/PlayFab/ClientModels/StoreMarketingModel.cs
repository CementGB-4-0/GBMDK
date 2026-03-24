using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class StoreMarketingModel : PlayFabBaseModel
    {
        public string Description;

        public string DisplayName;

        public object Metadata;
    }
}