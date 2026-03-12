using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GooglePlayFabIdPair : PlayFabBaseModel
    {
        public string GoogleId;

        public string PlayFabId;
    }
}