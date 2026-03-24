using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class AddUsernamePasswordRequest : PlayFabRequestCommon
    {
        public string Email;

        public string Password;

        public string Username;
        public Dictionary<string, string> CustomTags;
    }
}