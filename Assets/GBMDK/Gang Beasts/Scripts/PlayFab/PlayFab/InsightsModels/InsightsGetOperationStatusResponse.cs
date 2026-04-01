using System;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsGetOperationStatusResponse : PlayFabResultCommon
    {
        public string Message;

        public string OperationId;

        public string OperationType;

        public int OperationValue;

        public string Status;

        public DateTime OperationCompletedTime;

        public DateTime OperationLastUpdated;

        public DateTime OperationStartedTime;
    }
}