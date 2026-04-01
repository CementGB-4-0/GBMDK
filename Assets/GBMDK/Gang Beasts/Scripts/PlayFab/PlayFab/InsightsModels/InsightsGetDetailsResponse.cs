using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsGetDetailsResponse : PlayFabResultCommon
    {
        public uint DataUsageMb;

        public string ErrorMessage;

        public InsightsGetLimitsResponse Limits;

        public List<InsightsGetOperationStatusResponse> PendingOperations;

        public int PerformanceLevel;

        public int RetentionDays;
    }
}