using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetMicrosoftStoreAccessTokensResponse : PlayFabResultCommon
    {
        public string CollectionsAccessToken;

        public DateTime CollectionsAccessTokenExpirationDate;
    }
}