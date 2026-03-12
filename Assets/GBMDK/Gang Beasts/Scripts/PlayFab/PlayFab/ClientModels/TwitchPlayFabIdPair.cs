using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class TwitchPlayFabIdPair : PlayFabBaseModel
    {
        public string PlayFabId;

        public string TwitchId;
    }
}