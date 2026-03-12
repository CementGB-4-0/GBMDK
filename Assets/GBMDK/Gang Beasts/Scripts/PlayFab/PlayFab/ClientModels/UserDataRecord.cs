using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserDataRecord : PlayFabBaseModel
    {
        public string Value;
        public DateTime LastUpdated;

        public UserDataPermission? Permission;
    }
}