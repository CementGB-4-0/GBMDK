using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class SubscriptionDetails : PlayFabBaseModel
    {
        public double DurationInSeconds;
    }
}