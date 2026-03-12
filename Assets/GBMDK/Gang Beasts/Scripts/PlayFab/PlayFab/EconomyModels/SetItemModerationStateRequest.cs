using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class SetItemModerationStateRequest : PlayFabRequestCommon
    {
        public CatalogAlternateId AlternateId;

        public string Id;

        public string Reason;

        public Dictionary<string, string> CustomTags;

        public ModerationStatus? Status;
    }
}