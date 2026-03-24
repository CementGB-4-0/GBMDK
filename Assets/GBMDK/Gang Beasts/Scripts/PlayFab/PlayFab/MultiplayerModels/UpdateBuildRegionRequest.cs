using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class UpdateBuildRegionRequest : PlayFabRequestCommon
    {
        public string BuildId;

        public BuildRegionParams BuildRegion;

        public Dictionary<string, string> CustomTags;
    }
}