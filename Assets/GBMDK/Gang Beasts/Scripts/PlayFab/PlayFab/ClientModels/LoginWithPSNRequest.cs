using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginWithPSNRequest : PlayFabRequestCommon
    {
        public string AuthCode;

        public string EncryptedRequest;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string PlayerSecret;

        public string RedirectUri;

        public string TitleId;

        public bool? CreateAccount;

        public Dictionary<string, string> CustomTags;

        public int? IssuerId;
    }
}