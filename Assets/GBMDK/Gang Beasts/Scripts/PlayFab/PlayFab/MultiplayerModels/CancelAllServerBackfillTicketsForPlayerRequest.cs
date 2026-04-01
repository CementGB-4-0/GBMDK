using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CancelAllServerBackfillTicketsForPlayerRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public string QueueName;
        public Dictionary<string, string> CustomTags;
    }
}