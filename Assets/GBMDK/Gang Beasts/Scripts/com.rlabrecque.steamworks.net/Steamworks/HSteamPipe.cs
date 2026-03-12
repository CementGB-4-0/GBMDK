using System;

namespace Steamworks
{
    [Serializable]
    public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
    {
        public int m_HSteamPipe;

        public HSteamPipe(int value)
        {
            m_HSteamPipe = 0;
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

        public static bool operator ==(HSteamPipe x, HSteamPipe y)
        {
            return false;
        }

        public static bool operator !=(HSteamPipe x, HSteamPipe y)
        {
            return !(x == y);
        }

        public static explicit operator HSteamPipe(int value)
        {
            return default(HSteamPipe);
        }

        public bool Equals(HSteamPipe other)
        {
            return false;
        }

        public int CompareTo(HSteamPipe other)
        {
            return 0;
        }
    }
}