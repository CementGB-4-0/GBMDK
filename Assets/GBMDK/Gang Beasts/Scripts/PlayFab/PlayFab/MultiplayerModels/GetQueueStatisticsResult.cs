using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetQueueStatisticsResult : PlayFabResultCommon
    {
        public Statistics TimeToMatchStatisticsInSeconds;
        public uint? NumberOfPlayersMatching;
    }
}