using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class ExperimentExclusionGroup : PlayFabBaseModel
    {
        public string Description;

        public string ExclusionGroupId;

        public string Name;
    }
}