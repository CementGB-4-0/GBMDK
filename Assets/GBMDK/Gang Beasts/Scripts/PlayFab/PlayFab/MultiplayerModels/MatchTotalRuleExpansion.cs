using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MatchTotalRuleExpansion : PlayFabBaseModel
    {
        public List<OverrideDouble> MaxOverrides;

        public List<OverrideDouble> MinOverrides;

        public uint SecondsBetweenExpansions;
    }
}