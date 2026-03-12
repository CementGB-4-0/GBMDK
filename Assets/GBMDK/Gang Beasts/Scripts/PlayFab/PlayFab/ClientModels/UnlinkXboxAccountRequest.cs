using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UnlinkXboxAccountRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}