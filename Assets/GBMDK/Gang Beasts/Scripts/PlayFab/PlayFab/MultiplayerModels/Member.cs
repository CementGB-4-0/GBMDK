using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class Member : PlayFabBaseModel
    {
        public EntityKey MemberEntity;

        public string PubSubConnectionHandle;
        public Dictionary<string, string> MemberData;
    }
}