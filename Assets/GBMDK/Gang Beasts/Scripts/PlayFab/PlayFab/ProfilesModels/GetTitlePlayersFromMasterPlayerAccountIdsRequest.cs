using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class GetTitlePlayersFromMasterPlayerAccountIdsRequest : PlayFabRequestCommon
    {
        public List<string> MasterPlayerAccountIds;

        public string TitleId;
        public Dictionary<string, string> CustomTags;
    }
}