using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class BuildSelectionCriterion : PlayFabBaseModel
    {
        public Dictionary<string, uint> BuildWeightDistribution;
    }
}