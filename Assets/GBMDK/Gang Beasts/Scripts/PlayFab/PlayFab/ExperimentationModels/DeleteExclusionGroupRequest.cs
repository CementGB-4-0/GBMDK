using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class DeleteExclusionGroupRequest : PlayFabRequestCommon
    {
        public string ExclusionGroupId;
        public Dictionary<string, string> CustomTags;
    }
}