using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CreateServerBackfillTicketRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public int GiveUpAfterSeconds;

		public List<MatchmakingPlayerWithTeamAssignment> Members;

		public string QueueName;

		public ServerDetails ServerDetails;
	}
}
