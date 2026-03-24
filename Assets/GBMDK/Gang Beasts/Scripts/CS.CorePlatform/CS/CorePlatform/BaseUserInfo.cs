using System;
using Coatsink.Platform.Systems.User;

namespace CS.CorePlatform
{
    [Serializable]
    public struct BaseUserInfo
    {
        private OnlineID _userID;

        private PlatformKeys _platformKey;

        private string _userName;

        private bool _hasGenedHas;

        private int _hashCode;

        public ulong userID => 0uL;

        public OnlineID OnlineID => default(OnlineID);

        public PlatformKeys platformKey => default(PlatformKeys);

        public string userName => null;

        public UserInfo CSInfo => default(UserInfo);

        public BaseUserInfo(string userID, PlatformKeys platform, string name)
        {
            _userID = default(OnlineID);
            _platformKey = default(PlatformKeys);
            _userName = null;
            _hasGenedHas = false;
            _hashCode = 0;
        }

        public BaseUserInfo(ulong userID, PlatformKeys platform, string name)
        {
            _userID = default(OnlineID);
            _platformKey = default(PlatformKeys);
            _userName = null;
            _hasGenedHas = false;
            _hashCode = 0;
        }

        public BaseUserInfo(string userID, int platform, string name)
        {
            _userID = default(OnlineID);
            _platformKey = default(PlatformKeys);
            _userName = null;
            _hasGenedHas = false;
            _hashCode = 0;
        }

        public BaseUserInfo(ulong userID, int platform, string name)
        {
            _userID = default(OnlineID);
            _platformKey = default(PlatformKeys);
            _userName = null;
            _hasGenedHas = false;
            _hashCode = 0;
        }

        public void Blank()
        {
        }

        public void Set(ulong userID, PlatformKeys platform, string name)
        {
        }

        public void Set(string userID, PlatformKeys platform, string name)
        {
        }

        public void Set(BaseUserInfo copy)
        {
        }

        public BaseUserInfo(string fromString)
        {
            _userID = default(OnlineID);
            _platformKey = default(PlatformKeys);
            _userName = null;
            _hasGenedHas = false;
            _hashCode = 0;
        }

        public static bool operator ==(BaseUserInfo left, BaseUserInfo right)
        {
            return false;
        }

        public static bool operator !=(BaseUserInfo left, BaseUserInfo right)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public bool RawEquals(BaseUserInfo check)
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

        public int GetByteSize()
        {
            return 0;
        }

        public int AddToArray(byte[] target, int startAt)
        {
            return 0;
        }

        public BaseUserInfo(byte[] target, int readPoint, out int readEnd, int size = 0)
        {
            _userID = default(OnlineID);
            _platformKey = default(PlatformKeys);
            _userName = null;
            _hasGenedHas = false;
            _hashCode = 0;
            readEnd = default(int);
        }
    }
}