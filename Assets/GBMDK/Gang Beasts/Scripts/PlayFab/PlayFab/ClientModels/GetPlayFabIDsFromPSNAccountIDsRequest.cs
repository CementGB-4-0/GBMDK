using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayFabIDsFromPSNAccountIDsRequest : PlayFabRequestCommon
    {
        public List<string> PSNAccountIDs;
        public int? IssuerId;
    }
}