using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class PaginationResponse : PlayFabBaseModel
    {
        public string ContinuationToken;

        public uint? TotalMatchedLobbyCount;
    }
}