using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class InventoryItemReference : PlayFabBaseModel
    {
        public AlternateId AlternateId;

        public string Id;

        public string StackId;
    }
}