using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginWithTwitchRequest : PlayFabRequestCommon
    {
        public string AccessToken;

        public string EncryptedRequest;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string PlayerSecret;

        public string TitleId;

        public bool? CreateAccount;

        public Dictionary<string, string> CustomTags;
    }
}