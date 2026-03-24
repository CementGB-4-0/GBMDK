using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UnlinkOpenIdConnectRequest : PlayFabRequestCommon
    {
        public string ConnectionId;

        public Dictionary<string, string> CustomTags;
    }
}