using System;

namespace Steamworks
{
    [Serializable]
    public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
    {
        public int m_HSteamUser;

        public HSteamUser(int value)
        {
            m_HSteamUser = 0;
        }

        public override string ToString()
        {
            return null;
        }

        public override bool Equals(object other)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(HSteamUser x, HSteamUser y)
        {
            return false;
        }

        public static bool operator !=(HSteamUser x, HSteamUser y)
        {
            return !(x == y);
        }

        public static explicit operator HSteamUser(int value)
        {
            return default(HSteamUser);
        }

        public bool Equals(HSteamUser other)
        {
            return false;
        }

        public int CompareTo(HSteamUser other)
        {
            return 0;
        }
    }
}