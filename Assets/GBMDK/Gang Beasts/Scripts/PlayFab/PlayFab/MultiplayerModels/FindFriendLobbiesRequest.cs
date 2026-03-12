using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class FindFriendLobbiesRequest : PlayFabRequestCommon
    {
        public string Filter;

        public string OrderBy;

        public PaginationRequest Pagination;

        public string XboxToken;
        public Dictionary<string, string> CustomTags;

        public ExternalFriendSources? ExternalPlatformFriends;
    }
}