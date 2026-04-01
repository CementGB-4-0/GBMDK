using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class GetTreatmentAssignmentResult : PlayFabResultCommon
    {
        public TreatmentAssignment TreatmentAssignment;
    }
}