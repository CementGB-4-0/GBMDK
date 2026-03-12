using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class SharedGroupDataRecord : PlayFabBaseModel
    {
        public string LastUpdatedBy;

        public string Value;
        public DateTime LastUpdated;

        public UserDataPermission? Permission;
    }
}