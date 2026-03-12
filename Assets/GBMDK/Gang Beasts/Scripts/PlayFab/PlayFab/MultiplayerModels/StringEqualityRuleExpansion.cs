using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class StringEqualityRuleExpansion : PlayFabBaseModel
    {
        public List<bool> EnabledOverrides;

        public uint SecondsBetweenExpansions;
    }
}