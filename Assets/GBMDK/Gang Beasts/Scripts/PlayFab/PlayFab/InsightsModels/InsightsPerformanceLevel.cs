using System;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsPerformanceLevel : PlayFabBaseModel
    {
        public int ActiveEventExports;

        public int CacheSizeMB;

        public int Concurrency;

        public double CreditsPerMinute;

        public int EventsPerSecond;

        public int Level;

        public int MaxMemoryPerQueryMB;

        public int VirtualCpuCores;
    }
}