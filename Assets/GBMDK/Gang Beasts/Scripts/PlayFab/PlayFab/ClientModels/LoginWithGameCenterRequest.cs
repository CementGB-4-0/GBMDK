using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginWithGameCenterRequest : PlayFabRequestCommon
    {
        public string EncryptedRequest;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string PlayerId;

        public string PlayerSecret;

        public string PublicKeyUrl;

        public string Salt;

        public string Signature;

        public string Timestamp;

        public string TitleId;
        public bool? CreateAccount;

        public Dictionary<string, string> CustomTags;
    }
}