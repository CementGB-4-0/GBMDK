using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CustomDifferenceRuleExpansion : PlayFabBaseModel
    {
        public List<OverrideDouble> DifferenceOverrides;

        public uint SecondsBetweenExpansions;
    }
}