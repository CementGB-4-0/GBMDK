using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class DeleteBuildRequest : PlayFabRequestCommon
    {
        public string BuildId;

        public Dictionary<string, string> CustomTags;
    }
}