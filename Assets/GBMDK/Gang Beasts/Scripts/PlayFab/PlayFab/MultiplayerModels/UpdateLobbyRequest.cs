using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class UpdateLobbyRequest : PlayFabRequestCommon
    {
        public List<string> LobbyDataToDelete;

        public string LobbyId;

        public List<string> MemberDataToDelete;

        public EntityKey MemberEntity;

        public EntityKey Owner;

        public List<string> SearchDataToDelete;
        public AccessPolicy? AccessPolicy;

        public Dictionary<string, string> CustomTags;

        public Dictionary<string, string> LobbyData;

        public uint? MaxPlayers;

        public Dictionary<string, string> MemberData;

        public MembershipLock? MembershipLock;

        public Dictionary<string, string> SearchData;
    }
}