using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class FindFriendLobbiesResult : PlayFabResultCommon
    {
        public List<FriendLobbySummary> Lobbies;

        public PaginationResponse Pagination;
    }
}