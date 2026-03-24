using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetCatalogConfigResponse : PlayFabResultCommon
    {
        public CatalogConfig Config;
    }
}