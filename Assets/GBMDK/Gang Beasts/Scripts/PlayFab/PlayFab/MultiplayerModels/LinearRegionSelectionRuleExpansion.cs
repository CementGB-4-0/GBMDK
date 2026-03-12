using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class LinearRegionSelectionRuleExpansion : PlayFabBaseModel
    {
        public uint Delta;

        public uint Limit;

        public uint SecondsBetweenExpansions;
    }
}