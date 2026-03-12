using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsGetOperationStatusRequest : PlayFabRequestCommon
    {
        public string OperationId;
        public Dictionary<string, string> CustomTags;
    }
}