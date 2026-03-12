using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class RegionSelectionRule : PlayFabBaseModel
    {
        public CustomRegionSelectionRuleExpansion CustomExpansion;

        public LinearRegionSelectionRuleExpansion LinearExpansion;

        public uint MaxLatency;

        public string Name;

        public string Path;

        public double Weight;

        public uint? SecondsUntilOptional;
    }
}