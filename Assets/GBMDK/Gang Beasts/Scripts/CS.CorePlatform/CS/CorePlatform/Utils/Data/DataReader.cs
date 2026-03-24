namespace CS.CorePlatform.Utils.Data
{
    public class DataReader : DataStream
    {
        public DataReader()
        {
        }

        public DataReader(DataStream baseStream, bool copy)
        {
        }

        public DataReader(byte[] data, bool copy)
        {
        }

        public ushort ReadUInt16()
        {
            return 0;
        }

        public uint ReadUInt32()
        {
            return 0u;
        }

        public ulong ReadUInt64()
        {
            return 0uL;
        }

        public short ReadInt16()
        {
            return 0;
        }

        public int ReadInt32()
        {
            return 0;
        }

        public long ReadInt64()
        {
            return 0L;
        }

        public float ReadSingle()
        {
            return 0f;
        }

        public double ReadDouble()
        {
            return 0.0;
        }

        public char ReadChar()
        {
            return '\0';
        }

        public string ReadString()
        {
            return null;
        }

        public bool ReadBool()
        {
            return false;
        }

        public byte[] ReadBytes()
        {
            return null;
        }

        public byte ReadByte()
        {
            return 0;
        }
    }
}