using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetSharedGroupDataRequest : PlayFabRequestCommon
    {
        public List<string> Keys;

        public string SharedGroupId;
        public bool? GetMembers;
    }
}