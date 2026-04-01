using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ServerDetails : PlayFabBaseModel
    {
        public string Fqdn;

        public string IPV4Address;

        public List<Port> Ports;

        public string Region;
    }
}