using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class PurchaseInventoryItemsOperation : PlayFabBaseModel
    {
        public bool DeleteEmptyStacks;

        public InventoryItemReference Item;

        public InitialValues NewStackValues;

        public List<PurchasePriceAmount> PriceAmounts;

        public string StoreId;
        public int? Amount;

        public double? DurationInSeconds;
    }
}