using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class ScorecardDataRow : PlayFabBaseModel
    {
        public bool IsControl;

        public uint PlayerCount;

        public string VariantName;

        public Dictionary<string, MetricData> MetricDataRows;
    }
}