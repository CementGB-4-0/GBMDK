using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListPartyQosServersResponse : PlayFabResultCommon
    {
        public int PageSize;

        public List<QosServer> QosServers;

        public string SkipToken;
    }
}