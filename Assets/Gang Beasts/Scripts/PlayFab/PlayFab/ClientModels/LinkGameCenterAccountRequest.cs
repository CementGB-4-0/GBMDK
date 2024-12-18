using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkGameCenterAccountRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public bool? ForceLink;

		public string GameCenterId;

		public string PublicKeyUrl;

		public string Salt;

		public string Signature;

		public string Timestamp;
	}
}
