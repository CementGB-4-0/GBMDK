using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetMatchmakingQueueResult : PlayFabResultCommon
    {
        public MatchmakingQueueConfig MatchmakingQueue;
    }
}