using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserCustomIdInfo : PlayFabBaseModel
    {
        public string CustomId;
    }
}