using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateLobbyRequest : PlayFabRequestCommon
    {
        public uint MaxPlayers;

        public List<Member> Members;

        public EntityKey Owner;

        public bool UseConnections;
        public AccessPolicy? AccessPolicy;

        public Dictionary<string, string> CustomTags;

        public Dictionary<string, string> LobbyData;

        public OwnerMigrationPolicy? OwnerMigrationPolicy;

        public Dictionary<string, string> SearchData;
    }
}