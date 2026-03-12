using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class DeleteBuildRegionRequest : PlayFabRequestCommon
    {
        public string BuildId;

        public string Region;

        public Dictionary<string, string> CustomTags;
    }
}