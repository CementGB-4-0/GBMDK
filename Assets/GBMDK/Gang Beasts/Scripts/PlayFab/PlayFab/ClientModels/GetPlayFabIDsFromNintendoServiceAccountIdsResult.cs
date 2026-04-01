using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayFabIDsFromNintendoServiceAccountIdsResult : PlayFabResultCommon
    {
        public List<NintendoServiceAccountPlayFabIdPair> Data;
    }
}