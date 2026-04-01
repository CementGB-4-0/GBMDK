using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class QosServer : PlayFabBaseModel
    {
        public string Region;

        public string ServerUrl;
    }
}