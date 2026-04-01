using System;

namespace Coatsink.Platform.Systems.User
{
    [Serializable]
    public struct OnlineID
    {
        public static readonly OnlineID INVALID_ID;

        private string value;

        [NonSerialized] private ulong _longCache;

        [NonSerialized] private bool _longCached;

        private OnlineID(ulong value)
        {
            this.value = null;
            _longCache = 0uL;
            _longCached = false;
        }

        private OnlineID(string value)
        {
            this.value = null;
            _longCache = 0uL;
            _longCached = false;
        }

        public ulong GetAsUlong()
        {
            return 0uL;
        }

        public static implicit operator OnlineID(string value)
        {
            return default(OnlineID);
        }

        public static implicit operator OnlineID(ulong value)
        {
            return default(OnlineID);
        }

        public static implicit operator string(OnlineID record)
        {
            return null;
        }

        public static explicit operator ulong(OnlineID value)
        {
            return 0uL;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(OnlineID lhs, OnlineID rhs)
        {
            return false;
        }

        public static bool operator !=(OnlineID lhs, OnlineID rhs)
        {
            return false;
        }

        public bool IsValid()
        {
            return false;
        }

        public override string ToString()
        {
            return null;
        }
    }
}