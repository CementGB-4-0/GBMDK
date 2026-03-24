using System;

namespace Coatsink.Platform.Systems.Online
{
    [Serializable]
    public struct LobbyLongID : ILobbyID
    {
        public ulong Value { get; private set; }

        public PlatformID Platform { get; private set; }

        public LobbyLongID(ulong value, PlatformID platform)
        {
            Value = 0uL;
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