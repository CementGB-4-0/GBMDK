using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserAndroidDeviceInfo : PlayFabBaseModel
    {
        public string AndroidDeviceId;
    }
}