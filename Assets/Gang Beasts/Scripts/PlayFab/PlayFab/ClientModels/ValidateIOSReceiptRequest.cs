using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ValidateIOSReceiptRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public string CurrencyCode;

		public Dictionary<string, string> CustomTags;

		public int PurchasePrice;

		public string ReceiptData;
	}
}
