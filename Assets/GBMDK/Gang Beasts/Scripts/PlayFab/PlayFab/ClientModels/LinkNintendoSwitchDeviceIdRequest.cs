using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon
    {
        public string NintendoSwitchDeviceId;
        public Dictionary<string, string> CustomTags;

        public bool? ForceLink;
    }
}