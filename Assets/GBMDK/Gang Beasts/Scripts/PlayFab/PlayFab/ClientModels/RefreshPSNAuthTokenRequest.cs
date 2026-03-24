using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class RefreshPSNAuthTokenRequest : PlayFabRequestCommon
    {
        public string AuthCode;

        public string RedirectUri;

        public int? IssuerId;
    }
}