using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CatalogItemContainerInfo : PlayFabBaseModel
    {
        public List<string> ItemContents;

        public string KeyItemId;

        public List<string> ResultTableContents;

        public Dictionary<string, uint> VirtualCurrencyContents;
    }
}