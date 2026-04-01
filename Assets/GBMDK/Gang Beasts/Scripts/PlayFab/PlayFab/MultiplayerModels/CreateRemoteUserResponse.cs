using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateRemoteUserResponse : PlayFabResultCommon
    {
        public string Password;

        public string Username;
        public DateTime? ExpirationTime;
    }
}