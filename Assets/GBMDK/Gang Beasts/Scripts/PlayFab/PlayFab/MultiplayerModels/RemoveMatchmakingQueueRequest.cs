using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class RemoveMatchmakingQueueRequest : PlayFabRequestCommon
    {
        public string QueueName;
        public Dictionary<string, string> CustomTags;
    }
}