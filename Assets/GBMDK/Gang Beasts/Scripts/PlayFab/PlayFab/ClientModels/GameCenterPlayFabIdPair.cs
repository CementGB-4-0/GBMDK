using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GameCenterPlayFabIdPair : PlayFabBaseModel
    {
        public string GameCenterId;

        public string PlayFabId;
    }
}