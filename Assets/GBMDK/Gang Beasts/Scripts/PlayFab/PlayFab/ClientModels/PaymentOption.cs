using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PaymentOption : PlayFabBaseModel
    {
        public string Currency;

        public uint Price;

        public string ProviderName;

        public uint StoreCredit;
    }
}