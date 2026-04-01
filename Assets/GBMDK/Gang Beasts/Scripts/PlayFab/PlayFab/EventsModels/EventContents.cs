using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
    [Serializable]
    public class EventContents : PlayFabBaseModel
    {
        public EntityKey Entity;

        public string EventNamespace;

        public string Name;

        public string OriginalId;

        public string PayloadJSON;
        public Dictionary<string, string> CustomTags;

        public DateTime? OriginalTimestamp;

        public object Payload;
    }
}