using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetTitleMultiplayerServersQuotaChangeRequest : PlayFabRequestCommon
    {
        public string RequestId;
        public Dictionary<string, string> CustomTags;
    }
}