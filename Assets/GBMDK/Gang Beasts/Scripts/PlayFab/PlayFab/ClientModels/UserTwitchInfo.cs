using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserTwitchInfo : PlayFabBaseModel
    {
        public string TwitchId;

        public string TwitchUserName;
    }
}