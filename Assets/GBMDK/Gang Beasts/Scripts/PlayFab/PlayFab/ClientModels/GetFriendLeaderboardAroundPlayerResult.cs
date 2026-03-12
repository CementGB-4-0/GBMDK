using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetFriendLeaderboardAroundPlayerResult : PlayFabResultCommon
    {
        public List<PlayerLeaderboardEntry> Leaderboard;

        public int Version;

        public DateTime? NextReset;
    }
}