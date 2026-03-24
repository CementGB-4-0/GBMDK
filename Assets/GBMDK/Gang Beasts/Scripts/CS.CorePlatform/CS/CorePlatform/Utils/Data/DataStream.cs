namespace CS.CorePlatform.Utils.Data
{
    public class DataStream
    {
        public const int HEADER_TYPE_START = 1;

        public const int HEADER_DATA_AMOUNT = 2;

        public const int HEADER_DATA_START = 6;

        protected int _bufferPoint;

        protected byte[] _data;

        protected bool _dataNeedsFlipped;

        protected uint _dataSize;

        protected bool _dataSizeChange;

        public DataStream()
        {
        }

        public DataStream(byte[] data, bool copy)
        {
        }

        public DataStream(int bufferSize)
        {
        }

        public DataStream(DataStream baseStream, bool copy)
        {
        }

        public int BufferPoint
        {
            get { return 0; }
            set { }
        }

        public int DataSize => 0;

        public byte[] DataBuffer => null;

        public int RawBufferPoint => 0;

        public byte Flag
        {
            get { return 0; }
            protected set { }
        }

        public byte DataAt(int index)
        {
            return 0;
        }

        private void ReadyStream(int bufferSize = 0)
        {
        }

        public bool ApplyDataSteam(byte[] newData, bool copy)
        {
            return false;
        }

        protected void AddData(byte[] data, int amount = 0)
        {
        }

        protected void AddData(byte data)
        {
        }

        public void ClearStream()
        {
        }
    }
}