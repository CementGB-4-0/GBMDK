using System;

namespace Steamworks
{
    [Serializable]
    public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
    {
        public uint m_AccountID;

        public AccountID_t(uint value)
        {
            m_AccountID = 0u;
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

        public static bool operator ==(AccountID_t x, AccountID_t y)
        {
            return false;
        }

        public static bool operator !=(AccountID_t x, AccountID_t y)
        {
            return !(x == y);
        }

        public static explicit operator uint(AccountID_t that)
        {
            return 0u;
        }

        public bool Equals(AccountID_t other)
        {
            return false;
        }

        public int CompareTo(AccountID_t other)
        {
            return 0;
        }
    }
}