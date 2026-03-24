using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetBuildRequest : PlayFabRequestCommon
    {
        public string BuildId;

        public Dictionary<string, string> CustomTags;
    }
}