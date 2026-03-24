using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CustomTeamSizeBalanceRuleExpansion : PlayFabBaseModel
    {
        public List<OverrideUnsignedInt> DifferenceOverrides;

        public uint SecondsBetweenExpansions;
    }
}