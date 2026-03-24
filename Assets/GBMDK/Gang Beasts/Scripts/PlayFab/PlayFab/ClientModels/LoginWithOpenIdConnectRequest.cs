using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginWithOpenIdConnectRequest : PlayFabRequestCommon
    {
        public string ConnectionId;

        public string EncryptedRequest;

        public string IdToken;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string PlayerSecret;

        public string TitleId;

        public bool? CreateAccount;

        public Dictionary<string, string> CustomTags;
    }
}