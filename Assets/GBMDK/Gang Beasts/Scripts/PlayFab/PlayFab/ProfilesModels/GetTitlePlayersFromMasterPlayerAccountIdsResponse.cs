using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class GetTitlePlayersFromMasterPlayerAccountIdsResponse : PlayFabResultCommon
    {
        public string TitleId;

        public Dictionary<string, EntityKey> TitlePlayerAccounts;
    }
}