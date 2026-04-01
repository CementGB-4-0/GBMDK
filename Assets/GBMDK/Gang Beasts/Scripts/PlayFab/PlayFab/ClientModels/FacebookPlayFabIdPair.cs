using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class FacebookPlayFabIdPair : PlayFabBaseModel
    {
        public string FacebookId;

        public string PlayFabId;
    }
}