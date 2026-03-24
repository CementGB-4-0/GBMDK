using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class LinkedPlatformAccountModel : PlayFabBaseModel
    {
        public string Email;

        public string PlatformUserId;

        public string Username;

        public LoginIdentityProvider? Platform;
    }
}