using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ConsumeMicrosoftStoreEntitlementsResponse : PlayFabResultCommon
	{
		public List<ItemInstance> Items;
	}
}
