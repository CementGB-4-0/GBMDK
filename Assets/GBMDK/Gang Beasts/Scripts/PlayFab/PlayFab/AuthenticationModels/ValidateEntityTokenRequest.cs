using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
    [Serializable]
    public class ValidateEntityTokenRequest : PlayFabRequestCommon
    {
        public string EntityToken;
        public Dictionary<string, string> CustomTags;
    }
}