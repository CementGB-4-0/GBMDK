using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateTitleMultiplayerServersQuotaChangeResponse : PlayFabResultCommon
    {
        public string RequestId;

        public bool WasApproved;
    }
}