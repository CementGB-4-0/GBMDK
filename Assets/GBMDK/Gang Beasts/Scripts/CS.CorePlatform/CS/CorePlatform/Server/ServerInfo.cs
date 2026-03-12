using System;
using System.Collections.Generic;
using CS.CorePlatform.Utils.Data;

namespace CS.CorePlatform.Server
{
    [Serializable]
    public class ServerInfo : PlatformDataWrapper
    {
        public bool supportJoinOn;

        public string serverIP;

        public int serverPort;

        public XboxInfo xboxInfo;
        private ulong _version;

        private List<BaseUserInfo> members;

        private List<BaseUserInfo> platformHosts;

        public ServerInfo()
        {
        }

        public ServerInfo(ServerInfo a)
        {
        }

        public ulong Version
        {
            get { return 0uL; }
            set { }
        }

        public List<BaseUserInfo> Hosts => null;

        public List<BaseUserInfo> Players => null;

        public void Clear()
        {
        }

        public void Copy(ServerInfo a)
        {
        }

        public bool AddPlayer(BaseUserInfo user)
        {
            return false;
        }

        public bool RemovePlayer(BaseUserInfo user, bool replaceIfHost = false)
        {
            return false;
        }

        public bool TryHost(BaseUserInfo user, bool forceOverride)
        {
            return false;
        }

        public bool RemoveHost(BaseUserInfo user, bool replace = false)
        {
            return false;
        }

        public bool IsHost(BaseUserInfo user)
        {
            return false;
        }

        protected override void Serialize(DataWriter writer)
        {
        }

        protected override void Deserialize(DataReader reader)
        {
        }
    }
}