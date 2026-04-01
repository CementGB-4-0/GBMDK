using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginWithAndroidDeviceIDRequest : PlayFabRequestCommon
    {
        public string AndroidDevice;

        public string AndroidDeviceId;

        public string EncryptedRequest;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string OS;

        public string PlayerSecret;

        public string TitleId;

        public bool? CreateAccount;

        public Dictionary<string, string> CustomTags;
    }
}