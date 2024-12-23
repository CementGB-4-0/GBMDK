using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class DeleteBuildAliasRequest : PlayFabRequestCommon
	{
		public string AliasId;

		public Dictionary<string, string> CustomTags;
	}
}
