using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetLeaderboardResult : PlayFabResultCommon
    {
        public List<PlayerLeaderboardEntry> Leaderboard;

        public int Version;

        public DateTime? NextReset;
    }
}