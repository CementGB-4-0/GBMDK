using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class TransactionOperation : PlayFabBaseModel
    {
        public string ItemId;

        public string ItemType;

        public string StackId;

        public string Type;
        public int? Amount;

        public double? DurationInSeconds;
    }
}