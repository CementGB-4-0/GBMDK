using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListBuildAliasesResponse : PlayFabResultCommon
    {
        public List<BuildAliasDetailsResponse> BuildAliases;

        public int PageSize;

        public string SkipToken;
    }
}