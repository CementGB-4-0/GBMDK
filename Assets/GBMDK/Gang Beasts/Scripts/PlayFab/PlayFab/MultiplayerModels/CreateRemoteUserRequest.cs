using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateRemoteUserRequest : PlayFabRequestCommon
    {
        public string BuildId;

        public string Region;

        public string Username;

        public string VmId;

        public Dictionary<string, string> CustomTags;

        public DateTime? ExpirationTime;
    }
}