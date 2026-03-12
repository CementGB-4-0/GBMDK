using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListQosServersForTitleRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;

        public bool? IncludeAllRegions;
    }
}