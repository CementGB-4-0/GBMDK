using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateLobbyResult : PlayFabResultCommon
    {
        public string ConnectionString;

        public string LobbyId;
    }
}