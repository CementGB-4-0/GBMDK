using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class GetExclusionGroupsResult : PlayFabResultCommon
    {
        public List<ExperimentExclusionGroup> ExclusionGroups;
    }
}