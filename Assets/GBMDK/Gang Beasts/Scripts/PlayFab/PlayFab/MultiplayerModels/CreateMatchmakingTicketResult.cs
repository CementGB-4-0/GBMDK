using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateMatchmakingTicketResult : PlayFabResultCommon
    {
        public string TicketId;
    }
}