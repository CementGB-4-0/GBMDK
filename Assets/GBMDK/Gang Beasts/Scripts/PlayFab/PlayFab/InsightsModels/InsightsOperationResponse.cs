using System;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsOperationResponse : PlayFabResultCommon
    {
        public string Message;

        public string OperationId;

        public string OperationType;
    }
}