using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetMultiplayerServerLogsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string ServerId;
	}
}
