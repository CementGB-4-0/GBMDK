namespace CS.CorePlatform.Utils.Data
{
    public class PlatformDataWrapper
    {
        private DataWriter _dataStream;

        private bool _dirty;

        protected byte Flag
        {
            get { return 0; }
            set { }
        }

        public byte[] RawMessage => null;

        public DataWriter Message => null;

        public int RawMessageSize => 0;

        public bool Dirty
        {
            get { return false; }
            protected set { }
        }

        protected void RefreshMessage()
        {
        }

        public byte[] CopyMessage()
        {
            return null;
        }

        public void ApplyData(DataReader read)
        {
        }

        protected virtual void Serialize(DataWriter writer)
        {
        }

        protected virtual void Deserialize(DataReader reader)
        {
        }
    }
}