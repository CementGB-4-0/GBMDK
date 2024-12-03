using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UnlinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string NintendoSwitchDeviceId;
	}
}
