using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayFabIDsFromNintendoServiceAccountIdsRequest : PlayFabRequestCommon
    {
        public List<string> NintendoAccountIds;
    }
}