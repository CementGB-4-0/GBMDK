using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CatalogItemConsumableInfo : PlayFabBaseModel
    {
        public string UsagePeriodGroup;
        public uint? UsageCount;

        public uint? UsagePeriod;
    }
}