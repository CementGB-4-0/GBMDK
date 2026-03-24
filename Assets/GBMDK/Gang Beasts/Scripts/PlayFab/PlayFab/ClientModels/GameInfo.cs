using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GameInfo : PlayFabBaseModel
    {
        public string BuildVersion;

        public string GameMode;

        public string GameServerData;

        public string LobbyID;

        public List<string> PlayerUserIds;

        public uint RunTime;

        public string ServerIPV4Address;

        public string ServerIPV6Address;

        public string ServerPublicDNSName;

        public string StatisticName;

        public GameInstanceState? GameServerStateEnum;

        public DateTime? LastHeartbeat;

        public int? MaxPlayers;

        public Region? Region;

        public int? ServerPort;

        public Dictionary<string, string> Tags;
    }
}