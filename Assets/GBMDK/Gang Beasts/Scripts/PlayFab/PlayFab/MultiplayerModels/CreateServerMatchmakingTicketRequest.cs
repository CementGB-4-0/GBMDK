using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateServerMatchmakingTicketRequest : PlayFabRequestCommon
    {
        public int GiveUpAfterSeconds;

        public List<MatchmakingPlayer> Members;

        public string QueueName;
        public Dictionary<string, string> CustomTags;
    }
}