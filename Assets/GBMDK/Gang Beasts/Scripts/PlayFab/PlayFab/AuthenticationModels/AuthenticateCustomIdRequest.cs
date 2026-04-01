using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
    [Serializable]
    public class AuthenticateCustomIdRequest : PlayFabRequestCommon
    {
        public string CustomId;

        public Dictionary<string, string> CustomTags;
    }
}