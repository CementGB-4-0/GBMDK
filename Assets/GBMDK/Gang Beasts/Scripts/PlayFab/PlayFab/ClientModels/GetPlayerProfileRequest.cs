using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayerProfileRequest : PlayFabRequestCommon
    {
        public string PlayFabId;

        public PlayerProfileViewConstraints ProfileConstraints;
        public Dictionary<string, string> CustomTags;
    }
}