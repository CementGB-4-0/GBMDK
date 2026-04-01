using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetMatchResult : PlayFabResultCommon
    {
        public string ArrangementString;

        public string MatchId;

        public List<MatchmakingPlayerWithTeamAssignment> Members;

        public List<string> RegionPreferences;

        public ServerDetails ServerDetails;
    }
}