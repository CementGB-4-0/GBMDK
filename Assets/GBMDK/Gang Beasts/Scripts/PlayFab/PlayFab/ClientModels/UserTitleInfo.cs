using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserTitleInfo : PlayFabBaseModel
    {
        public string AvatarUrl;

        public string DisplayName;

        public EntityKey TitlePlayerAccount;

        public DateTime Created;

        public DateTime? FirstLogin;

        public bool? isBanned;

        public DateTime? LastLogin;

        public UserOrigination? Origination;
    }
}