using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListMultiplayerServersRequest : PlayFabRequestCommon
    {
        public string BuildId;

        public string Region;

        public string SkipToken;

        public Dictionary<string, string> CustomTags;

        public int? PageSize;
    }
}