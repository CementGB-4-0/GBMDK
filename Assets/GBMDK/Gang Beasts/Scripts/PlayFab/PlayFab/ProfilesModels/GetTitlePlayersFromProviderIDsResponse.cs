using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class GetTitlePlayersFromProviderIDsResponse : PlayFabResultCommon
    {
        public Dictionary<string, EntityLineage> TitlePlayerAccounts;
    }
}