using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MatchTotalRule : PlayFabBaseModel
    {
        public QueueRuleAttribute Attribute;

        public MatchTotalRuleExpansion Expansion;

        public double Max;

        public double Min;

        public string Name;

        public double Weight;

        public uint? SecondsUntilOptional;
    }
}