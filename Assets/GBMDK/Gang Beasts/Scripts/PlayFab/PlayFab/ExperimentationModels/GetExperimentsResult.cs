using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class GetExperimentsResult : PlayFabResultCommon
    {
        public List<Experiment> Experiments;
    }
}