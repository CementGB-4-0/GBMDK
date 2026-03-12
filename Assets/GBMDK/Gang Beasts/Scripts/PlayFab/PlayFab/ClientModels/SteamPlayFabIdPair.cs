using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class SteamPlayFabIdPair : PlayFabBaseModel
    {
        public string PlayFabId;

        public string SteamStringId;
    }
}