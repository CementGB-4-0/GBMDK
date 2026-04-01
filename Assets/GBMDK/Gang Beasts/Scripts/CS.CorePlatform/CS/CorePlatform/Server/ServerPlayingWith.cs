using UnityEngine;

namespace CS.CorePlatform.Server
{
    public class ServerPlayingWith : MonoBehaviour
    {
        private ServerInfo _lastInfo;
        private bool _needsSent;

        public bool SupportJoinOn
        {
            get { return false; }
            set { }
        }

        public uint XboxPlayers
        {
            get { return 0u; }
            set { }
        }

        public bool NeedsSend => false;

        public ServerInfo LastInfo => null;

        private void SetNeedsWrite()
        {
        }

        public void MarkWriten()
        {
        }

        private void StartPlaying(string ip, int port)
        {
        }

        public void UpdateSession(BaseUserInfo sender, byte[] newInfo)
        {
        }

        public void AddPlayer(BaseUserInfo user)
        {
        }

        public void RemovePlayer(BaseUserInfo user)
        {
        }
    }
}