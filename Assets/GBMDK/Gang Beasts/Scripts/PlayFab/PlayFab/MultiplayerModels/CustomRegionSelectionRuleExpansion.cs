using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CustomRegionSelectionRuleExpansion : PlayFabBaseModel
    {
        public List<OverrideUnsignedInt> MaxLatencyOverrides;

        public uint SecondsBetweenExpansions;
    }
}