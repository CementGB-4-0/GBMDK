using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class UpdateExperimentRequest : PlayFabRequestCommon
    {
        public string Description;

        public string ExclusionGroupId;

        public string Id;

        public string Name;

        public string SegmentId;

        public List<string> TitlePlayerAccountTestIds;

        public List<Variant> Variants;
        public Dictionary<string, string> CustomTags;

        public DateTime? EndDate;

        public uint? ExclusionGroupTrafficAllocation;

        public ExperimentType? ExperimentType;

        public DateTime StartDate;
    }
}