using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PlayerProfileModel : PlayFabBaseModel
    {
        public List<AdCampaignAttributionModel> AdCampaignAttributions;

        public string AvatarUrl;

        public List<ContactEmailInfoModel> ContactEmailAddresses;

        public string DisplayName;

        public List<string> ExperimentVariants;

        public List<LinkedPlatformAccountModel> LinkedAccounts;

        public List<LocationModel> Locations;

        public List<MembershipModel> Memberships;

        public string PlayerId;

        public string PublisherId;

        public List<PushNotificationRegistrationModel> PushNotificationRegistrations;

        public List<StatisticModel> Statistics;

        public List<TagModel> Tags;

        public string TitleId;

        public List<ValueToDateModel> ValuesToDate;

        public DateTime? BannedUntil;

        public DateTime? Created;

        public DateTime? LastLogin;

        public LoginIdentityProvider? Origination;

        public uint? TotalValueToDateInUSD;
    }
}