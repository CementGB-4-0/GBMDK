using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class QuotaChange : PlayFabBaseModel
    {
        public string ChangeDescription;

        public List<CoreCapacityChange> Changes;

        public bool IsPendingReview;

        public string Notes;

        public string RequestId;

        public string ReviewComments;

        public bool WasApproved;
    }
}