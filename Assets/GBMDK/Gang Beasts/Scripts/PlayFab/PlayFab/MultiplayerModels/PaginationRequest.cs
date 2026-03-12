using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class PaginationRequest : PlayFabBaseModel
    {
        public string ContinuationToken;

        public uint? PageSizeRequested;
    }
}