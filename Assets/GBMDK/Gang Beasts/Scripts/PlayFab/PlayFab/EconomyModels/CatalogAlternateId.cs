using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogAlternateId : PlayFabBaseModel
    {
        public string Type;

        public string Value;
    }
}