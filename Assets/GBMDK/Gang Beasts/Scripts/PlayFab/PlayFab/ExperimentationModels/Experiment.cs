using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class Experiment : PlayFabBaseModel
    {
        public string Description;

        public string ExclusionGroupId;

        public string Id;

        public string Name;

        public string SegmentId;

        public List<string> TitlePlayerAccountTestIds;

        public List<Variant> Variants;

        public DateTime? EndDate;

        public uint? ExclusionGroupTrafficAllocation;

        public ExperimentType? ExperimentType;

        public DateTime StartDate;

        public ExperimentState? State;
    }
}