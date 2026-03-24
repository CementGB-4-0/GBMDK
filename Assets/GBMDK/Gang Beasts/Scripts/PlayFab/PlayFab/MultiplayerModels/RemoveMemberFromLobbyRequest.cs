using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class RemoveMemberFromLobbyRequest : PlayFabRequestCommon
    {
        public string LobbyId;

        public EntityKey MemberEntity;

        public bool PreventRejoin;
        public Dictionary<string, string> CustomTags;
    }
}