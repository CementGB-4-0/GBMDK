using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class CreateExperimentResult : PlayFabResultCommon
    {
        public string ExperimentId;
    }
}