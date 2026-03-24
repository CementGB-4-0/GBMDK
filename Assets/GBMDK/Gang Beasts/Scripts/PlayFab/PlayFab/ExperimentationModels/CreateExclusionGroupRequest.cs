using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class CreateExclusionGroupRequest : PlayFabRequestCommon
    {
        public string Description;

        public string Name;
        public Dictionary<string, string> CustomTags;
    }
}