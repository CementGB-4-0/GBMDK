using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class WriteClientCharacterEventRequest : PlayFabRequestCommon
    {
        public string CharacterId;

        public string EventName;
        public Dictionary<string, object> Body;

        public Dictionary<string, string> CustomTags;

        public DateTime? Timestamp;
    }
}