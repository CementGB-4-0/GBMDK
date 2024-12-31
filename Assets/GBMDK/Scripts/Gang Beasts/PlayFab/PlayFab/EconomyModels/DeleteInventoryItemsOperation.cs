using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class DeleteInventoryItemsOperation : PlayFabBaseModel
	{
		public InventoryItemReference Item;
	}
}
