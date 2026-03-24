using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
    [Serializable]
    [StructLayout((LayoutKind)0, Pack = 4, Size = 8)]
    public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
    {
        public static readonly CSteamID Nil;

        public static readonly CSteamID OutofDateGS;

        public static readonly CSteamID LanModeGS;

        public static readonly CSteamID NotInitYetGS;

        public static readonly CSteamID NonSteamGS;

        public ulong m_SteamID;

        public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
        {
            m_SteamID = 0uL;
        }

        public CSteamID(ulong ulSteamID)
        {
            m_SteamID = 0uL;
        }

        public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse,
            EAccountType eAccountType)
        {
        }

        public void SetAccountID(AccountID_t other)
        {
        }

        public void SetAccountInstance(uint other)
        {
        }

        public void SetEAccountType(EAccountType other)
        {
        }

        public void SetEUniverse(EUniverse other)
        {
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

        public static bool operator ==(CSteamID x, CSteamID y)
        {
            return false;
        }

        public static bool operator !=(CSteamID x, CSteamID y)
        {
            return !(x == y);
        }

        public static explicit operator CSteamID(ulong value)
        {
            return default(CSteamID);
        }

        public static explicit operator ulong(CSteamID that)
        {
            return 0uL;
        }

        public bool Equals(CSteamID other)
        {
            return false;
        }

        public int CompareTo(CSteamID other)
        {
            return 0;
        }
    }
}