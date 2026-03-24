using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class GetExperimentsRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}