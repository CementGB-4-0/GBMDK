using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class GetExclusionGroupTrafficResult : PlayFabResultCommon
    {
        public List<ExclusionGroupTrafficAllocation> TrafficAllocations;
    }
}