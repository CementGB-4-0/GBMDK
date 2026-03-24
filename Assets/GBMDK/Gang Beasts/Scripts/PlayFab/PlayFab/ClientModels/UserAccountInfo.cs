using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserAccountInfo : PlayFabBaseModel
    {
        public UserAndroidDeviceInfo AndroidDeviceInfo;

        public UserAppleIdInfo AppleAccountInfo;

        public UserCustomIdInfo CustomIdInfo;

        public UserFacebookInfo FacebookInfo;

        public UserFacebookInstantGamesIdInfo FacebookInstantGamesIdInfo;

        public UserGameCenterInfo GameCenterInfo;

        public UserGoogleInfo GoogleInfo;

        public UserGooglePlayGamesInfo GooglePlayGamesInfo;

        public UserIosDeviceInfo IosDeviceInfo;

        public UserKongregateInfo KongregateInfo;

        public UserNintendoSwitchAccountIdInfo NintendoSwitchAccountInfo;

        public UserNintendoSwitchDeviceIdInfo NintendoSwitchDeviceIdInfo;

        public List<UserOpenIdInfo> OpenIdInfo;

        public string PlayFabId;

        public UserPrivateAccountInfo PrivateInfo;

        public UserPsnInfo PsnInfo;

        public UserSteamInfo SteamInfo;

        public UserTitleInfo TitleInfo;

        public UserTwitchInfo TwitchInfo;

        public string Username;

        public UserXboxInfo XboxInfo;

        public DateTime Created;
    }
}