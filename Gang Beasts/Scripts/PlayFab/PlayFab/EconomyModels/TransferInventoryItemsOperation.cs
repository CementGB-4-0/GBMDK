using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class TransferInventoryItemsOperation : PlayFabBaseModel
	{
		public int? Amount;

		public bool DeleteEmptyStacks;

		public InventoryItemReference GivingItem;

		public InitialValues NewStackValues;

		public InventoryItemReference ReceivingItem;
	}
}
