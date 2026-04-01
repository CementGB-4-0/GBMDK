using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class SubtractUserVirtualCurrencyRequest : PlayFabRequestCommon
    {
        public int Amount;

        public string VirtualCurrency;

        public Dictionary<string, string> CustomTags;
    }
}