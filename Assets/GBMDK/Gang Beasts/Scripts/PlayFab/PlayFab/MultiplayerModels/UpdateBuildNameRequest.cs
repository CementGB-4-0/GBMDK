using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class UpdateBuildNameRequest : PlayFabRequestCommon
    {
        public string BuildId;

        public string BuildName;

        public Dictionary<string, string> CustomTags;
    }
}