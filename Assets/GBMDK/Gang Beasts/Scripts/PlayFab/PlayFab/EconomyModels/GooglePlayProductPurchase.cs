using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GooglePlayProductPurchase : PlayFabBaseModel
    {
        public string ProductId;

        public string Token;
    }
}