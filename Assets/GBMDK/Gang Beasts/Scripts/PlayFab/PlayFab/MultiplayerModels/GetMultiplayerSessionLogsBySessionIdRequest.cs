using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetMultiplayerSessionLogsBySessionIdRequest : PlayFabRequestCommon
    {
        public string SessionId;
        public Dictionary<string, string> CustomTags;
    }
}