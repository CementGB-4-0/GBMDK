using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetSharedGroupDataResult : PlayFabResultCommon
    {
        public List<string> Members;
        public Dictionary<string, SharedGroupDataRecord> Data;
    }
}