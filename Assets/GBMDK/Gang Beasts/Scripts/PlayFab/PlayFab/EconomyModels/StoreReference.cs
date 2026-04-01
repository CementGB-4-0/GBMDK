using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class StoreReference : PlayFabBaseModel
    {
        public CatalogAlternateId AlternateId;

        public string Id;
    }
}