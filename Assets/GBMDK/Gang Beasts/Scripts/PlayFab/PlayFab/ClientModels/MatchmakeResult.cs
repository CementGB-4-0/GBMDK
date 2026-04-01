using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class MatchmakeResult : PlayFabResultCommon
    {
        public string Expires;

        public string LobbyID;

        public string ServerIPV4Address;

        public string ServerIPV6Address;

        public string ServerPublicDNSName;

        public string Ticket;

        public int? PollWaitTimeMS;

        public int? ServerPort;

        public MatchmakeStatus? Status;
    }
}