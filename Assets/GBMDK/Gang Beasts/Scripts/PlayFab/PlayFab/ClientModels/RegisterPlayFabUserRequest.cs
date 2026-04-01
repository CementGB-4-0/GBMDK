using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class RegisterPlayFabUserRequest : PlayFabRequestCommon
    {
        public string DisplayName;

        public string Email;

        public string EncryptedRequest;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string Password;

        public string PlayerSecret;

        public string TitleId;

        public string Username;
        public Dictionary<string, string> CustomTags;

        public bool? RequireBothUsernameAndEmail;
    }
}