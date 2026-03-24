using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CurrentGamesRequest : PlayFabRequestCommon
    {
        public string BuildVersion;

        public string GameMode;

        public string StatisticName;

        public CollectionFilter TagFilter;

        public Region? Region;
    }
}