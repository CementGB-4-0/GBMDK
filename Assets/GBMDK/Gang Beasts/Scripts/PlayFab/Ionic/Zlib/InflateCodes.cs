namespace Ionic.Zlib
{
    internal sealed class InflateCodes
    {
        private const int START = 0;

        private const int LEN = 1;

        private const int LENEXT = 2;

        private const int DIST = 3;

        private const int DISTEXT = 4;

        private const int COPY = 5;

        private const int LIT = 6;

        private const int WASH = 7;

        private const int END = 8;

        private const int BADCODE = 9;

        internal int bitsToGet;

        internal byte dbits;

        internal int dist;

        internal int[] dtree;

        internal int dtree_index;

        internal byte lbits;

        internal int len;

        internal int lit;

        internal int[] ltree;

        internal int ltree_index;

        internal int mode;

        internal int need;

        internal int[] tree;

        internal int tree_index;

        internal InflateCodes()
        {
        }

        internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
        {
        }

        internal int Process(InflateBlocks blocks, int r)
        {
            return 0;
        }

        internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s,
            ZlibCodec z)
        {
            return 0;
        }
    }
}