using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateServerBackfillTicketResult : PlayFabResultCommon
    {
        public string TicketId;
    }
}