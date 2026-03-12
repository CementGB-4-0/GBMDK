using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UnlinkGoogleAccountRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}