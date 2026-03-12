using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class AddOrUpdateContactEmailRequest : PlayFabRequestCommon
    {
        public string EmailAddress;
        public Dictionary<string, string> CustomTags;
    }
}