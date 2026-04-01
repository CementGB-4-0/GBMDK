using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetLeaderboardAroundPlayerRequest : PlayFabRequestCommon
    {
        public string PlayFabId;

        public PlayerProfileViewConstraints ProfileConstraints;

        public string StatisticName;
        public Dictionary<string, string> CustomTags;

        public int? MaxResultsCount;

        public int? Version;
    }
}