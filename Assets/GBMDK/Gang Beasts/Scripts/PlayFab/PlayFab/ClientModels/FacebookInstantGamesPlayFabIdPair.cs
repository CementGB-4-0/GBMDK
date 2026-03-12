using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class FacebookInstantGamesPlayFabIdPair : PlayFabBaseModel
    {
        public string FacebookInstantGamesId;

        public string PlayFabId;
    }
}