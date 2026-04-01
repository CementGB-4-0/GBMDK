using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class FriendInfo : PlayFabBaseModel
    {
        public UserFacebookInfo FacebookInfo;

        public string FriendPlayFabId;

        public UserGameCenterInfo GameCenterInfo;

        public PlayerProfileModel Profile;

        public UserPsnInfo PSNInfo;

        public UserSteamInfo SteamInfo;

        public List<string> Tags;

        public string TitleDisplayName;

        public string Username;

        public UserXboxInfo XboxInfo;
    }
}