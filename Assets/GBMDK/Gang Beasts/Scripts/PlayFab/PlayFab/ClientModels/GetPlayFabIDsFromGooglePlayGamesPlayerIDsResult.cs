using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult : PlayFabResultCommon
    {
        public List<GooglePlayGamesPlayFabIdPair> Data;
    }
}