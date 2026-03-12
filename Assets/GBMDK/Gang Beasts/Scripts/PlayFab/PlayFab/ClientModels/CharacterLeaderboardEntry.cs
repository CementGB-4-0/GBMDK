using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CharacterLeaderboardEntry : PlayFabBaseModel
    {
        public string CharacterId;

        public string CharacterName;

        public string CharacterType;

        public string DisplayName;

        public string PlayFabId;

        public int Position;

        public int StatValue;
    }
}