using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserGameCenterInfo : PlayFabBaseModel
    {
        public string GameCenterId;
    }
}