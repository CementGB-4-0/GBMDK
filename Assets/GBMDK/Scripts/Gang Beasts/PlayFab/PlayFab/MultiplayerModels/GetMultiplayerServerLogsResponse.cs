using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetMultiplayerServerLogsResponse : PlayFabResultCommon
	{
		public string LogDownloadUrl;
	}
}
