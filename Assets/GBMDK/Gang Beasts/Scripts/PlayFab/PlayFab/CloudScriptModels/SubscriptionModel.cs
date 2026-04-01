using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class SubscriptionModel : PlayFabBaseModel
    {
        public bool IsActive;

        public string SubscriptionId;

        public string SubscriptionItemId;

        public string SubscriptionProvider;
        public DateTime Expiration;

        public DateTime InitialSubscriptionTime;

        public SubscriptionProviderStatus? Status;
    }
}