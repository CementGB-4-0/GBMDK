using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class TeamTicketSizeSimilarityRule : PlayFabBaseModel
    {
        public string Name;

        public uint? SecondsUntilOptional;
    }
}