using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class GetTitlePlayersFromXboxLiveIDsRequest : PlayFabRequestCommon
    {
        public string Sandbox;

        public string TitleId;

        public List<string> XboxLiveIds;
        public Dictionary<string, string> CustomTags;
    }
}