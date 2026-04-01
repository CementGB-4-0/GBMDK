using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class FindLobbiesRequest : PlayFabRequestCommon
    {
        public string Filter;

        public string OrderBy;

        public PaginationRequest Pagination;
        public Dictionary<string, string> CustomTags;
    }
}