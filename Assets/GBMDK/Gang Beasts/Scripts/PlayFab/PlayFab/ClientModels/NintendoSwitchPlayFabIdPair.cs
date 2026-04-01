using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class NintendoSwitchPlayFabIdPair : PlayFabBaseModel
    {
        public string NintendoSwitchDeviceId;

        public string PlayFabId;
    }
}