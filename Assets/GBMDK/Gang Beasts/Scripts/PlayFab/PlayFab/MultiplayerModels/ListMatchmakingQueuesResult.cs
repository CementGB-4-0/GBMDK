using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListMatchmakingQueuesResult : PlayFabResultCommon
    {
        public List<MatchmakingQueueConfig> MatchMakingQueues;
    }
}