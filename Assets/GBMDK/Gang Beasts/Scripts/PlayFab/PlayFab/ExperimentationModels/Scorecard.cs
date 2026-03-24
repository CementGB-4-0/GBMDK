using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class Scorecard : PlayFabBaseModel
    {
        public string DateGenerated;

        public string Duration;

        public double EventsProcessed;

        public string ExperimentId;

        public string ExperimentName;

        public bool SampleRatioMismatch;

        public List<ScorecardDataRow> ScorecardDataRows;

        public AnalysisTaskState? LatestJobStatus;
    }
}