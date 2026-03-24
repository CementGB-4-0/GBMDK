using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsSetPerformanceRequest : PlayFabRequestCommon
    {
        public int PerformanceLevel;
        public Dictionary<string, string> CustomTags;
    }
}