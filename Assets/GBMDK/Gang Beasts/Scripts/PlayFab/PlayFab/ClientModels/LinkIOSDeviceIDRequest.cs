using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkIOSDeviceIDRequest : PlayFabRequestCommon
    {
        public string DeviceId;

        public string DeviceModel;

        public string OS;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}