using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class StoreItem : PlayFabBaseModel
    {
        public string ItemId;
        public object CustomData;

        public uint? DisplayPosition;

        public Dictionary<string, uint> RealCurrencyPrices;

        public Dictionary<string, uint> VirtualCurrencyPrices;
    }
}