using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserOpenIdInfo : PlayFabBaseModel
    {
        public string ConnectionId;

        public string Issuer;

        public string Subject;
    }
}