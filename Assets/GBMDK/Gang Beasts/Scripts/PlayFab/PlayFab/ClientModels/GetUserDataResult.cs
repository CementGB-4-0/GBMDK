using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetUserDataResult : PlayFabResultCommon
    {
        public uint DataVersion;
        public Dictionary<string, UserDataRecord> Data;
    }
}