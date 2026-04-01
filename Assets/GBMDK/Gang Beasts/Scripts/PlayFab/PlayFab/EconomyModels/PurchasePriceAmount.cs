using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class PurchasePriceAmount : PlayFabBaseModel
    {
        public int Amount;

        public string ItemId;

        public string StackId;
    }
}