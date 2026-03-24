using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsGetLimitsResponse : PlayFabResultCommon
    {
        public int DefaultPerformanceLevel;

        public int DefaultStorageRetentionDays;

        public int StorageMaxRetentionDays;

        public int StorageMinRetentionDays;

        public List<InsightsPerformanceLevel> SubMeters;
    }
}