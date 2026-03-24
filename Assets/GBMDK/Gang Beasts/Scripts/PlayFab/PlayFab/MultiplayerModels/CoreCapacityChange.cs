using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CoreCapacityChange : PlayFabBaseModel
    {
        public int NewCoreLimit;

        public string Region;

        public AzureVmFamily VmFamily;
    }
}