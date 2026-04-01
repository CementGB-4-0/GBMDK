using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetUserDataRequest : PlayFabRequestCommon
    {
        public List<string> Keys;

        public string PlayFabId;
        public uint? IfChangedFromDataVersion;
    }
}