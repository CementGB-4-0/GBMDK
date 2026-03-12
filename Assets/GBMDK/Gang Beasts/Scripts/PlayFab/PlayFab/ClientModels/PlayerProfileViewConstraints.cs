using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PlayerProfileViewConstraints : PlayFabBaseModel
    {
        public bool ShowAvatarUrl;

        public bool ShowBannedUntil;

        public bool ShowCampaignAttributions;

        public bool ShowContactEmailAddresses;

        public bool ShowCreated;

        public bool ShowDisplayName;

        public bool ShowExperimentVariants;

        public bool ShowLastLogin;

        public bool ShowLinkedAccounts;

        public bool ShowLocations;

        public bool ShowMemberships;

        public bool ShowOrigination;

        public bool ShowPushNotificationRegistrations;

        public bool ShowStatistics;

        public bool ShowTags;

        public bool ShowTotalValueToDateInUsd;

        public bool ShowValuesToDate;
    }
}