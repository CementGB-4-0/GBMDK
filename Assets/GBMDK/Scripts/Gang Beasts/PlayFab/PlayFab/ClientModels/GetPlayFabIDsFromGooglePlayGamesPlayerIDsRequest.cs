using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest : PlayFabRequestCommon
	{
		public List<string> GooglePlayGamesPlayerIDs;
	}
}
