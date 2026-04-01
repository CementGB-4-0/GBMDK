using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsGetPendingOperationsRequest : PlayFabRequestCommon
    {
        public string OperationType;
        public Dictionary<string, string> CustomTags;
    }
}