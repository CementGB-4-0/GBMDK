using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CancelServerBackfillTicketRequest : PlayFabRequestCommon
    {
        public string QueueName;

        public string TicketId;
        public Dictionary<string, string> CustomTags;
    }
}