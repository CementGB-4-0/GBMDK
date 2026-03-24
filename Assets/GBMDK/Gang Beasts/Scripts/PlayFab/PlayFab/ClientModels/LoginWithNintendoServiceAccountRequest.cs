using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginWithNintendoServiceAccountRequest : PlayFabRequestCommon
    {
        public string EncryptedRequest;

        public string IdentityToken;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string PlayerSecret;

        public string TitleId;
        public bool? CreateAccount;

        public Dictionary<string, string> CustomTags;
    }
}