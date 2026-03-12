using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MatchmakingPlayer : PlayFabBaseModel
    {
        public MatchmakingPlayerAttributes Attributes;

        public EntityKey Entity;
    }
}