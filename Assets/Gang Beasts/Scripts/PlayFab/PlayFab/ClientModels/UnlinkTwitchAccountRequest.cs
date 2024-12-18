using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UnlinkTwitchAccountRequest : PlayFabRequestCommon
	{
		public string AccessToken;

		public Dictionary<string, string> CustomTags;
	}
}
