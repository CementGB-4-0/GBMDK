using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetServerBackfillTicketResult : PlayFabResultCommon
    {
        public string CancellationReasonString;

        public int GiveUpAfterSeconds;

        public string MatchId;

        public List<MatchmakingPlayerWithTeamAssignment> Members;

        public string QueueName;

        public ServerDetails ServerDetails;

        public string Status;

        public string TicketId;

        public DateTime Created;
    }
}