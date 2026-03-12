using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MatchmakingPlayerWithTeamAssignment : PlayFabBaseModel
    {
        public MatchmakingPlayerAttributes Attributes;

        public EntityKey Entity;

        public string TeamId;
    }
}