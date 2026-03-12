using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class RequestMultiplayerServerResponse : PlayFabResultCommon
    {
        public string BuildId;

        public List<ConnectedPlayer> ConnectedPlayers;

        public string FQDN;

        public string IPV4Address;

        public List<Port> Ports;

        public string Region;

        public string ServerId;

        public string SessionId;

        public string State;

        public string VmId;

        public DateTime? LastStateTransitionTime;
    }
}