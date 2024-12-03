using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class WriteTitleEventRequest : PlayFabRequestCommon
	{
		public Dictionary<string, object> Body;

		public Dictionary<string, string> CustomTags;

		public string EventName;

		public DateTime? Timestamp;
	}
}
