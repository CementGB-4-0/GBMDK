using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PushNotificationRegistrationModel : PlayFabBaseModel
    {
        public string NotificationEndpointARN;

        public PushNotificationPlatform? Platform;
    }
}