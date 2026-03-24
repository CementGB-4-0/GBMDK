using System;

namespace Coatsink.Platform.Systems.Online
{
    [Serializable]
    public struct LobbyGUID : ILobbyID
    {
        public Guid Value { get; private set; }

        public PlatformID Platform { get; private set; }

        public LobbyGUID(Guid value, PlatformID platform)
        {
            Value = default(Guid);
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