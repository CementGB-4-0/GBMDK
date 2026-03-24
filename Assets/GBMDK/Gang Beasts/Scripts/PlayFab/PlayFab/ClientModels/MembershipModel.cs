using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class MembershipModel : PlayFabBaseModel
    {
        public bool IsActive;

        public string MembershipId;

        public List<SubscriptionModel> Subscriptions;

        public DateTime MembershipExpiration;

        public DateTime? OverrideExpiration;
    }
}