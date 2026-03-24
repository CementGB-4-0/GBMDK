using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GooglePlayGamesPlayFabIdPair : PlayFabBaseModel
    {
        public string GooglePlayGamesPlayerId;

        public string PlayFabId;
    }
}