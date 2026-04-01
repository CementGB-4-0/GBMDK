using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class RequestMultiplayerServerRequest : PlayFabRequestCommon
    {
        public BuildAliasParams BuildAliasParams;

        public string BuildId;

        public List<string> InitialPlayers;

        public List<string> PreferredRegions;

        public string SessionCookie;

        public string SessionId;

        public Dictionary<string, string> CustomTags;
    }
}