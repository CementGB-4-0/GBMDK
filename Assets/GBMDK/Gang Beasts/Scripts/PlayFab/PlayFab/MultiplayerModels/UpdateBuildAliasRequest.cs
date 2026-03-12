using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class UpdateBuildAliasRequest : PlayFabRequestCommon
    {
        public string AliasId;

        public string AliasName;

        public List<BuildSelectionCriterion> BuildSelectionCriteria;

        public Dictionary<string, string> CustomTags;
    }
}