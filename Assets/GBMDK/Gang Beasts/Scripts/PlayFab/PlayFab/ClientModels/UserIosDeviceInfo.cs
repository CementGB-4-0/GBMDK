using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserIosDeviceInfo : PlayFabBaseModel
    {
        public string IosDeviceId;
    }
}