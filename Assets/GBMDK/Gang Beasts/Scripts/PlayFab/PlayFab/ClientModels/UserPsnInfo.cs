using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserPsnInfo : PlayFabBaseModel
    {
        public string PsnAccountId;

        public string PsnOnlineId;
    }
}