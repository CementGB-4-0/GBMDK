using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListMatchmakingQueuesRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}