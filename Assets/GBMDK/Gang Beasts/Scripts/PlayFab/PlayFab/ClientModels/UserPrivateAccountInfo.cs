using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserPrivateAccountInfo : PlayFabBaseModel
    {
        public string Email;
    }
}