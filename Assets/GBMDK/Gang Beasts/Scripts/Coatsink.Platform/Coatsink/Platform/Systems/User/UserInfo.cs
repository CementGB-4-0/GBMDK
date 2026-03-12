using System;

namespace Coatsink.Platform.Systems.User
{
    [Serializable]
    public struct UserInfo
    {
        public static readonly UserInfo INVALID_ID;

        private PlatformID platformID;

        private OnlineID onlineID;

        public PlatformID PlatformID => default(PlatformID);

        public OnlineID OnlineID => default(OnlineID);

        public UserInfo(PlatformID platform, OnlineID online)
        {
            platformID = default(PlatformID);
            onlineID = default(OnlineID);
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(UserInfo a, UserInfo b)
        {
            return false;
        }

        public static bool operator !=(UserInfo a, UserInfo b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return null;
        }
    }
}