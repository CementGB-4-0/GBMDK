using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetLobbyResult : PlayFabResultCommon
    {
        public Lobby Lobby;
    }
}