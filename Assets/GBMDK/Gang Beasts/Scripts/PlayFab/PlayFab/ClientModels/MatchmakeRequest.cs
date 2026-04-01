using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class MatchmakeRequest : PlayFabRequestCommon
    {
        public string BuildVersion;

        public string CharacterId;

        public string GameMode;

        public string LobbyId;

        public string StatisticName;

        public CollectionFilter TagFilter;

        public Dictionary<string, string> CustomTags;

        public Region? Region;

        public bool? StartNewIfNoneFound;
    }
}