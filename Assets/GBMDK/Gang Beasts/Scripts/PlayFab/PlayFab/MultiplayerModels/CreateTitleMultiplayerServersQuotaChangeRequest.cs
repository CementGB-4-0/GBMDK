using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateTitleMultiplayerServersQuotaChangeRequest : PlayFabRequestCommon
    {
        public string ChangeDescription;

        public List<CoreCapacityChange> Changes;

        public string ContactEmail;

        public string Notes;

        public Dictionary<string, string> CustomTags;

        public DateTime? StartDate;
    }
}