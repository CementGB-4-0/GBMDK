using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class MetricData : PlayFabBaseModel
    {
        public double ConfidenceIntervalEnd;

        public double ConfidenceIntervalStart;

        public float DeltaAbsoluteChange;

        public float DeltaRelativeChange;

        public string InternalName;

        public string Movement;

        public string Name;

        public float PMove;

        public float PValue;

        public float PValueThreshold;

        public string StatSigLevel;

        public float StdDev;

        public float Value;
    }
}