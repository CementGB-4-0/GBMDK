using System;

namespace Steamworks
{
    [Serializable]
    public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
    {
        public static readonly PublishedFileId_t Invalid;

        public ulong m_PublishedFileId;

        public PublishedFileId_t(ulong value)
        {
            m_PublishedFileId = 0uL;
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

        public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
        {
            return false;
        }

        public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
        {
            return !(x == y);
        }

        public bool Equals(PublishedFileId_t other)
        {
            return false;
        }

        public int CompareTo(PublishedFileId_t other)
        {
            return 0;
        }
    }
}