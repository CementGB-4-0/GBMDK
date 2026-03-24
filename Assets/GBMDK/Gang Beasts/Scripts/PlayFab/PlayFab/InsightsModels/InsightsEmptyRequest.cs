using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
    [Serializable]
    public class InsightsEmptyRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}