using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class GetTreatmentAssignmentRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;
        public Dictionary<string, string> CustomTags;
    }
}