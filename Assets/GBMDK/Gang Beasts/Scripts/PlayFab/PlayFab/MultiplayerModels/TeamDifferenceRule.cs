using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class TeamDifferenceRule : PlayFabBaseModel
    {
        public QueueRuleAttribute Attribute;

        public CustomTeamDifferenceRuleExpansion CustomExpansion;

        public double DefaultAttributeValue;

        public double Difference;

        public LinearTeamDifferenceRuleExpansion LinearExpansion;

        public string Name;

        public uint? SecondsUntilOptional;
    }
}