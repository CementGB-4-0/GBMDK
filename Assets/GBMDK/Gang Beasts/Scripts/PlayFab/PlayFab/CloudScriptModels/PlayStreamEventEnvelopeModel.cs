using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class PlayStreamEventEnvelopeModel : PlayFabBaseModel
    {
        public string EntityId;

        public string EntityType;

        public string EventData;

        public string EventName;

        public string EventNamespace;

        public string EventSettings;
    }
}