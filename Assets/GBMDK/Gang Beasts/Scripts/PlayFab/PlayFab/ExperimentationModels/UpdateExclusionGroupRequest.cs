using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class UpdateExclusionGroupRequest : PlayFabRequestCommon
    {
        public string Description;

        public string ExclusionGroupId;

        public string Name;
        public Dictionary<string, string> CustomTags;
    }
}