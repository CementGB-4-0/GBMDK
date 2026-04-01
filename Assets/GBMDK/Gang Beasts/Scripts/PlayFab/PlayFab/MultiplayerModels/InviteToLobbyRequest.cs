using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class InviteToLobbyRequest : PlayFabRequestCommon
    {
        public EntityKey InviteeEntity;

        public string LobbyId;

        public EntityKey MemberEntity;
        public Dictionary<string, string> CustomTags;
    }
}