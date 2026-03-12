using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class ExclusionGroupTrafficAllocation : PlayFabBaseModel
    {
        public string ExperimentId;

        public uint TrafficAllocation;
    }
}