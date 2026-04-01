using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MatchmakingQueueTeam : PlayFabBaseModel
    {
        public uint MaxTeamSize;

        public uint MinTeamSize;

        public string Name;
    }
}