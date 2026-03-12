using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class CreateExclusionGroupResult : PlayFabResultCommon
    {
        public string ExclusionGroupId;
    }
}