using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class LeaveLobbyRequest : PlayFabRequestCommon
    {
        public string LobbyId;

        public EntityKey MemberEntity;
        public Dictionary<string, string> CustomTags;
    }
}