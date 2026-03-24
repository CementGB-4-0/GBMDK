using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MultiplayerServerSummary : PlayFabBaseModel
    {
        public List<ConnectedPlayer> ConnectedPlayers;

        public string Region;

        public string ServerId;

        public string SessionId;

        public string State;

        public string VmId;

        public DateTime? LastStateTransitionTime;
    }
}