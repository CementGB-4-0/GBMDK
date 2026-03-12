using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class SubtractInventoryItemsOperation : PlayFabBaseModel
    {
        public bool DeleteEmptyStacks;

        public InventoryItemReference Item;
        public int? Amount;

        public double? DurationInSeconds;
    }
}