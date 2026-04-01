using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsGetPendingOperationsResponse : PlayFabResultCommon
    {
        public List<InsightsGetOperationStatusResponse> PendingOperations;
    }
}