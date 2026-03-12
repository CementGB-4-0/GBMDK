using System;

namespace Coatsink.Platform.Systems.Online
{
    [Serializable]
    public struct LobbyStringID : ILobbyID
    {
        public string Value { get; private set; }

        public PlatformID Platform { get; private set; }

        public LobbyStringID(PlatformID platform)
        {
            Value = null;
            Platform = default(PlatformID);
        }

        public LobbyStringID(string value, PlatformID platform)
        {
            Value = null;
            Platform = default(PlatformID);
        }

        public bool IsValid()
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }
    }
}