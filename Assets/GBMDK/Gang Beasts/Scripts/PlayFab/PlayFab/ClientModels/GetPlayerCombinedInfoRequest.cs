using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayerCombinedInfoRequest : PlayFabRequestCommon
    {
        public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

        public string PlayFabId;
        public Dictionary<string, string> CustomTags;
    }
}