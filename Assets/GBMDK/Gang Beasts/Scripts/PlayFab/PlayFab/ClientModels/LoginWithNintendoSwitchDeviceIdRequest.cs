using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LoginWithNintendoSwitchDeviceIdRequest : PlayFabRequestCommon
    {
        public string EncryptedRequest;

        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string NintendoSwitchDeviceId;

        public string PlayerSecret;

        public string TitleId;
        public bool? CreateAccount;

        public Dictionary<string, string> CustomTags;
    }
}