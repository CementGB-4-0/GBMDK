using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CustomSetIntersectionRuleExpansion : PlayFabBaseModel
    {
        public List<OverrideUnsignedInt> MinIntersectionSizeOverrides;

        public uint SecondsBetweenExpansions;
    }
}