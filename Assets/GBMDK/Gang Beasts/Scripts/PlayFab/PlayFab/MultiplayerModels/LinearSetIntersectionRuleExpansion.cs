using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class LinearSetIntersectionRuleExpansion : PlayFabBaseModel
    {
        public uint Delta;

        public uint SecondsBetweenExpansions;
    }
}