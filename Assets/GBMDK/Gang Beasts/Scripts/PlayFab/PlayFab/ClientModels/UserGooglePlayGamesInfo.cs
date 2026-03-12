using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserGooglePlayGamesInfo : PlayFabBaseModel
    {
        public string GooglePlayGamesPlayerAvatarImageUrl;

        public string GooglePlayGamesPlayerDisplayName;

        public string GooglePlayGamesPlayerId;
    }
}