using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class UpdateInventoryItemsOperation : PlayFabBaseModel
    {
        public InventoryItem Item;
    }
}