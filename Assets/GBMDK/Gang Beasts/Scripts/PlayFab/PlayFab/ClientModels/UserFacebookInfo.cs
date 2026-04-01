using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserFacebookInfo : PlayFabBaseModel
    {
        public string FacebookId;

        public string FullName;
    }
}