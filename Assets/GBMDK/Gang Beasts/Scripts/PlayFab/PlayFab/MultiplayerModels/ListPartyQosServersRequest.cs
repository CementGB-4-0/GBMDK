using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListPartyQosServersRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}