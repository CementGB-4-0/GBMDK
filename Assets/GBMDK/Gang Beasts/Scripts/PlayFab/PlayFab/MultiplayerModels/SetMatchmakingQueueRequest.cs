using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class SetMatchmakingQueueRequest : PlayFabRequestCommon
    {
        public MatchmakingQueueConfig MatchmakingQueue;
        public Dictionary<string, string> CustomTags;
    }
}