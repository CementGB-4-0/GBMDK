using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class ModerationState : PlayFabBaseModel
    {
        public string Reason;
        public DateTime? LastModifiedDate;

        public ModerationStatus? Status;
    }
}