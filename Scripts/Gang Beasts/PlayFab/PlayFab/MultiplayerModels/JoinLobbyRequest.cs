using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class JoinLobbyRequest : PlayFabRequestCommon
	{
		public string ConnectionString;

		public Dictionary<string, string> CustomTags;

		public Dictionary<string, string> MemberData;

		public EntityKey MemberEntity;
	}
}
