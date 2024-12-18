using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class InventoryItem : PlayFabBaseModel
	{
		public int? Amount;

		public object DisplayProperties;

		public DateTime? ExpirationDate;

		public string Id;

		public string StackId;

		public string Type;
	}
}
