using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class Certificate : PlayFabBaseModel
    {
        public string Base64EncodedValue;

        public string Name;

        public string Password;
    }
}