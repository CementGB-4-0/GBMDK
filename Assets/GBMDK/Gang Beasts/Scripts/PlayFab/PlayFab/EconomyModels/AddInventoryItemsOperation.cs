using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class AddInventoryItemsOperation : PlayFabBaseModel
    {
        public InventoryItemReference Item;

        public InitialValues NewStackValues;
        public int? Amount;

        public double? DurationInSeconds;
    }
}