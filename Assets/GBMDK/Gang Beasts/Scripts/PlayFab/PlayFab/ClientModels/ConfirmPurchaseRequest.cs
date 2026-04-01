using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ConfirmPurchaseRequest : PlayFabRequestCommon
    {
        public string OrderId;
        public Dictionary<string, string> CustomTags;
    }
}