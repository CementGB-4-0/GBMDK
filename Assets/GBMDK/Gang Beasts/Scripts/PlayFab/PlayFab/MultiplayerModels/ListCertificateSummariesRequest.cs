using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListCertificateSummariesRequest : PlayFabRequestCommon
    {
        public string SkipToken;
        public Dictionary<string, string> CustomTags;

        public int? PageSize;
    }
}