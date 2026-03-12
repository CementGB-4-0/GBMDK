using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class LobbySummary : PlayFabBaseModel
    {
        public string ConnectionString;

        public uint CurrentPlayers;

        public string LobbyId;

        public uint MaxPlayers;

        public EntityKey Owner;

        public MembershipLock? MembershipLock;

        public Dictionary<string, string> SearchData;
    }
}