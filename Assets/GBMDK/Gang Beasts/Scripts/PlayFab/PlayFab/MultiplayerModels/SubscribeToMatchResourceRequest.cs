using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class SubscribeToMatchResourceRequest : PlayFabRequestCommon
    {
        public EntityKey EntityKey;

        public string PubSubConnectionHandle;

        public string ResourceId;

        public uint SubscriptionVersion;

        public string Type;
        public Dictionary<string, string> CustomTags;
    }
}