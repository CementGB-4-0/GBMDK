using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class FindLobbiesResult : PlayFabResultCommon
    {
        public List<LobbySummary> Lobbies;

        public PaginationResponse Pagination;
    }
}