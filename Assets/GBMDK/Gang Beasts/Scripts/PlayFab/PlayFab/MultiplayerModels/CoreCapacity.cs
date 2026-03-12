using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CoreCapacity : PlayFabBaseModel
    {
        public int Available;

        public string Region;

        public int Total;

        public AzureVmFamily? VmFamily;
    }
}