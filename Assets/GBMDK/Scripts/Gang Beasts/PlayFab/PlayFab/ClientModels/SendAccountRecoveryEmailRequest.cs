using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class SendAccountRecoveryEmailRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string Email;

		public string EmailTemplateId;

		public string TitleId;
	}
}
