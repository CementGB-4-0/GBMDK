using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetMatchmakingTicketResult : PlayFabResultCommon
    {
        public string CancellationReasonString;

        public EntityKey Creator;

        public int GiveUpAfterSeconds;

        public string MatchId;

        public List<MatchmakingPlayer> Members;

        public List<EntityKey> MembersToMatchWith;

        public string QueueName;

        public string Status;

        public string TicketId;

        public uint? ChangeNumber;

        public DateTime Created;
    }
}