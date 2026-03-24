using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayerTagsRequest : PlayFabRequestCommon
    {
        public string Namespace;

        public string PlayFabId;
        public Dictionary<string, string> CustomTags;
    }
}