using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class GetInventoryItemsRequest : PlayFabRequestCommon
	{
		public string CollectionId;

		public string ContinuationToken;

		public int Count;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public string Filter;
	}
}
