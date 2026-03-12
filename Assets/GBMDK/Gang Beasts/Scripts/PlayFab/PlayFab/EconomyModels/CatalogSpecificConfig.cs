using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogSpecificConfig : PlayFabBaseModel
    {
        public List<string> ContentTypes;

        public List<string> Tags;
    }
}