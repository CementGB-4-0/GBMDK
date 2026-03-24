using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class InventoryOperation : PlayFabBaseModel
    {
        public AddInventoryItemsOperation Add;

        public DeleteInventoryItemsOperation Delete;

        public PurchaseInventoryItemsOperation Purchase;

        public SubtractInventoryItemsOperation Subtract;

        public TransferInventoryItemsOperation Transfer;

        public UpdateInventoryItemsOperation Update;
    }
}