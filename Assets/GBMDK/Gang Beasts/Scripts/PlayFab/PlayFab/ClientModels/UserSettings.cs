using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UserSettings : PlayFabBaseModel
    {
        public bool GatherDeviceInfo;

        public bool GatherFocusInfo;

        public bool NeedsAttribution;
    }
}