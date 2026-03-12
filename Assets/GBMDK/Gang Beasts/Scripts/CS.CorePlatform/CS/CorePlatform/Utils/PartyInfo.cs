using System;
using Coatsink.Platform.Systems.Online;

namespace CS.CorePlatform.Utils
{
    [Serializable]
    public struct PartyInfo
    {
        private string _writtenLobby;

        private ILobbyID _lobbyID;

        private PlatformKeys _platformKey;

        public ILobbyID LobbyID => null;

        public PlatformKeys platformKey => default(PlatformKeys);

        public PartyInfo(ILobbyID lobbyID, PlatformKeys platform)
        {
            _writtenLobby = null;
            _lobbyID = null;
            _platformKey = default(PlatformKeys);
        }

        public void Blank()
        {
        }

        public void Set(PlatformKeys platform, ILobbyID lobbyID)
        {
        }

        public PartyInfo(string fromString)
        {
            _writtenLobby = null;
            _lobbyID = null;
            _platformKey = default(PlatformKeys);
        }

        public static bool operator ==(PartyInfo left, PartyInfo right)
        {
            return false;
        }

        public static bool operator !=(PartyInfo left, PartyInfo right)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public bool RawEquals(PartyInfo check)
        {
            return false;
        }

        public override string ToString()
        {
            return null;
        }

        private string WriteLobby()
        {
            return null;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}