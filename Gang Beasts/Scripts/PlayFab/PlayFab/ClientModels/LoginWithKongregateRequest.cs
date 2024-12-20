using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithKongregateRequest : PlayFabRequestCommon
	{
		public string AuthTicket;

		public bool? CreateAccount;

		public Dictionary<string, string> CustomTags;

		public string EncryptedRequest;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string KongregateId;

		public string PlayerSecret;

		public string TitleId;
	}
}
