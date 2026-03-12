using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class RewardAdActivityResult : PlayFabResultCommon
    {
        public string AdActivityEventId;

        public List<string> DebugResults;

        public string PlacementId;

        public string PlacementName;

        public AdRewardResults RewardResults;

        public int? PlacementViewsRemaining;

        public double? PlacementViewsResetMinutes;
    }
}