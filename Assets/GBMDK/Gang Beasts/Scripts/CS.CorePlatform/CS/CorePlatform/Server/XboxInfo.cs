using System;
using CS.CorePlatform.Utils.Data;

namespace CS.CorePlatform.Server
{
    [Serializable]
    public struct XboxInfo : WriteData
    {
        public uint version;

        public uint maxPlayers;

        public string sessionSearchHandle;

        public void WriteData(DataWriter writer)
        {
        }

        public void ReadData(DataReader reader)
        {
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public static bool operator ==(XboxInfo a, XboxInfo b)
        {
            return false;
        }

        public static bool operator !=(XboxInfo a, XboxInfo b)
        {
            return false;
        }
    }
}