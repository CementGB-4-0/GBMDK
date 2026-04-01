using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class GetLatestScorecardResult : PlayFabResultCommon
    {
        public Scorecard Scorecard;
    }
}