namespace Ionic.Zlib
{
    internal class WorkItem
    {
        public byte[] buffer;

        public byte[] compressed;

        public int compressedBytesAvailable;

        public ZlibCodec compressor;

        public int crc;

        public int index;

        public int inputBytesAvailable;

        public int ordinal;

        public WorkItem(int size, CompressionLevel compressLevel, CompressionStrategy strategy, int ix)
        {
        }
    }
}