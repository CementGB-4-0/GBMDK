using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UnlinkNintendoServiceAccountRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}