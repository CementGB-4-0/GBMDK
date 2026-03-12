using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CharacterResult : PlayFabBaseModel
    {
        public string CharacterId;

        public string CharacterName;

        public string CharacterType;
    }
}