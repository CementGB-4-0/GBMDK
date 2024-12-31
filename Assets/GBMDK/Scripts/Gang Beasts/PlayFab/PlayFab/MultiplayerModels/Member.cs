using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class Member : PlayFabBaseModel
	{
		public Dictionary<string, string> MemberData;

		public EntityKey MemberEntity;

		public string PubSubConnectionHandle;
	}
}
