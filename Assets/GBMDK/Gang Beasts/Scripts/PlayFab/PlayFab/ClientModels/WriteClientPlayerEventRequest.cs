using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class WriteClientPlayerEventRequest : PlayFabRequestCommon
    {
        public string EventName;
        public Dictionary<string, object> Body;

        public Dictionary<string, string> CustomTags;

        public DateTime? Timestamp;
    }
}