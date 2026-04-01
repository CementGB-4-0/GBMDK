using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class BuildAliasDetailsResponse : PlayFabResultCommon
    {
        public string AliasId;

        public string AliasName;

        public List<BuildSelectionCriterion> BuildSelectionCriteria;
    }
}