using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetTitleMultiplayerServersQuotasRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}