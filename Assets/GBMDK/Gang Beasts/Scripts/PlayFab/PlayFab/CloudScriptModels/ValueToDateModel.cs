using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ValueToDateModel : PlayFabBaseModel
    {
        public string Currency;

        public uint TotalValue;

        public string TotalValueAsDecimal;
    }
}