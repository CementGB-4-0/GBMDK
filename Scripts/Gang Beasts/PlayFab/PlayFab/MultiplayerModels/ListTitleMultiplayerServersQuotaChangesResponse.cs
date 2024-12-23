using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class ListTitleMultiplayerServersQuotaChangesResponse : PlayFabResultCommon
	{
		public List<QuotaChange> Changes;
	}
}
