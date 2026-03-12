using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class VirtualMachineSummary : PlayFabBaseModel
    {
        public string HealthStatus;

        public string State;

        public string VmId;
    }
}