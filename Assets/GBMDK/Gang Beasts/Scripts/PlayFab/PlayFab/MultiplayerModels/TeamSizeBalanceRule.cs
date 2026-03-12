using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class TeamSizeBalanceRule : PlayFabBaseModel
    {
        public CustomTeamSizeBalanceRuleExpansion CustomExpansion;

        public uint Difference;

        public LinearTeamSizeBalanceRuleExpansion LinearExpansion;

        public string Name;

        public uint? SecondsUntilOptional;
    }
}