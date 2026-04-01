using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetLeaderboardRequest : PlayFabRequestCommon
    {
        public PlayerProfileViewConstraints ProfileConstraints;

        public int StartPosition;

        public string StatisticName;
        public Dictionary<string, string> CustomTags;

        public int? MaxResultsCount;

        public int? Version;
    }
}