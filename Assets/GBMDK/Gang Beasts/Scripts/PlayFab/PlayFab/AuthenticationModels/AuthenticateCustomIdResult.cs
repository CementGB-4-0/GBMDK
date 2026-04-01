using System;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
    [Serializable]
    public class AuthenticateCustomIdResult : PlayFabResultCommon
    {
        public EntityTokenResponse EntityToken;

        public bool NewlyCreated;
    }
}