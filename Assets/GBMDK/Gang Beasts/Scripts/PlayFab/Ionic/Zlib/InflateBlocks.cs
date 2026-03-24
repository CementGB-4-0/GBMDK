namespace Ionic.Zlib
{
    internal sealed class InflateBlocks
    {
        private const int MANY = 1440;

        internal static readonly int[] border;

        internal ZlibCodec _codec;

        internal int[] bb;

        internal int bitb;

        internal int bitk;

        internal int[] blens;

        internal uint check;

        internal object checkfn;

        internal InflateCodes codes;

        internal int end;

        internal int[] hufts;

        internal int index;

        internal InfTree inftree;

        internal int last;

        internal int left;

        private InflateBlockMode mode;

        internal int readAt;

        internal int table;

        internal int[] tb;

        internal byte[] window;

        internal int writeAt;

        internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
        {
        }

        internal uint Reset()
        {
            return 0u;
        }

        internal int Process(int r)
        {
            return 0;
        }

        internal void Free()
        {
        }

        internal void SetDictionary(byte[] d, int start, int n)
        {
        }

        internal int SyncPoint()
        {
            return 0;
        }

        internal int Flush(int r)
        {
            return 0;
        }

        private enum InflateBlockMode
        {
            TYPE = 0,
            LENS = 1,
            STORED = 2,
            TABLE = 3,
            BTREE = 4,
            DTREE = 5,
            CODES = 6,
            DRY = 7,
            DONE = 8,
            BAD = 9
        }
    }
}