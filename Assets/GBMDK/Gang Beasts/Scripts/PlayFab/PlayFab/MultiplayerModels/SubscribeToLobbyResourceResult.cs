using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class SubscribeToLobbyResourceResult : PlayFabResultCommon
    {
        public string Topic;
    }
}