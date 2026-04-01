using System;

namespace Steamworks
{
    [Serializable]
    public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
    {
        public static readonly SteamAPICall_t Invalid;

        public ulong m_SteamAPICall;

        public SteamAPICall_t(ulong value)
        {
            m_SteamAPICall = 0uL;
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

        public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
        {
            return false;
        }

        public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
        {
            return !(x == y);
        }

        public static explicit operator ulong(SteamAPICall_t that)
        {
            return 0uL;
        }

        public bool Equals(SteamAPICall_t other)
        {
            return false;
        }

        public int CompareTo(SteamAPICall_t other)
        {
            return 0;
        }
    }
}