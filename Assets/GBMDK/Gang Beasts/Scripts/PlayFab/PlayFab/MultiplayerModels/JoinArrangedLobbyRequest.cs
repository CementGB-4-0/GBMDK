using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class JoinArrangedLobbyRequest : PlayFabRequestCommon
    {
        public string ArrangementString;

        public uint MaxPlayers;

        public EntityKey MemberEntity;

        public bool UseConnections;
        public AccessPolicy? AccessPolicy;

        public Dictionary<string, string> CustomTags;

        public Dictionary<string, string> MemberData;

        public OwnerMigrationPolicy? OwnerMigrationPolicy;
    }
}