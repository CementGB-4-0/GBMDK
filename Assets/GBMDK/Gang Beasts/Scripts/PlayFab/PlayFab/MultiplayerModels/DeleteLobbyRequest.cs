using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class DeleteLobbyRequest : PlayFabRequestCommon
    {
        public string LobbyId;
        public Dictionary<string, string> CustomTags;
    }
}