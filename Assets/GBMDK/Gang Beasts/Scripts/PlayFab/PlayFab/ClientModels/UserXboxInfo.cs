using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserXboxInfo : PlayFabBaseModel
    {
        public string XboxUserId;

        public string XboxUserSandbox;
    }
}