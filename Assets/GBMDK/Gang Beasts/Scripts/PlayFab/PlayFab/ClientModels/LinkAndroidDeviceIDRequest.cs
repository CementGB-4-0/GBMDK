using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkAndroidDeviceIDRequest : PlayFabRequestCommon
    {
        public string AndroidDevice;

        public string AndroidDeviceId;

        public string OS;

        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}