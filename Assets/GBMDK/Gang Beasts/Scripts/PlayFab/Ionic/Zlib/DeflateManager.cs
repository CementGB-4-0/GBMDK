namespace Ionic.Zlib
{
    internal sealed class DeflateManager
    {
        private static readonly int MEM_LEVEL_MAX;

        private static readonly int MEM_LEVEL_DEFAULT;

        private static readonly string[] _ErrorMessage;

        private static readonly int PRESET_DICT;

        private static readonly int INIT_STATE;

        private static readonly int BUSY_STATE;

        private static readonly int FINISH_STATE;

        private static readonly int Z_DEFLATED;

        private static readonly int STORED_BLOCK;

        private static readonly int STATIC_TREES;

        private static readonly int DYN_TREES;

        private static readonly int Z_BINARY;

        private static readonly int Z_ASCII;

        private static readonly int Z_UNKNOWN;

        private static readonly int Buf_size;

        private static readonly int MIN_MATCH;

        private static readonly int MAX_MATCH;

        private static readonly int MIN_LOOKAHEAD;

        private static readonly int HEAP_SIZE;

        private static readonly int END_BLOCK;

        internal ZlibCodec _codec;

        internal int _distanceOffset;

        internal int _lengthOffset;

        private bool _WantRfc1950HeaderBytes;

        internal short bi_buf;

        internal int bi_valid;

        internal short[] bl_count;

        internal short[] bl_tree;

        internal int block_start;

        internal CompressionLevel compressionLevel;

        internal CompressionStrategy compressionStrategy;

        private Config config;

        internal sbyte data_type;

        private CompressFunc DeflateFunction;

        internal sbyte[] depth;

        internal short[] dyn_dtree;

        internal short[] dyn_ltree;

        internal int hash_bits;

        internal int hash_mask;

        internal int hash_shift;

        internal int hash_size;

        internal short[] head;

        internal int[] heap;

        internal int heap_len;

        internal int heap_max;

        internal int ins_h;

        internal int last_eob_len;

        internal int last_flush;

        internal int last_lit;

        internal int lit_bufsize;

        internal int lookahead;

        internal int match_available;

        internal int match_length;

        internal int match_start;

        internal int matches;

        internal int nextPending;

        internal int opt_len;

        internal byte[] pending;

        internal int pendingCount;

        internal short[] prev;

        internal int prev_length;

        internal int prev_match;

        private bool Rfc1950BytesEmitted;

        internal int static_len;

        internal int status;

        internal int strstart;

        internal ZTree treeBitLengths;

        internal ZTree treeDistances;

        internal ZTree treeLiterals;

        internal int w_bits;

        internal int w_mask;

        internal int w_size;

        internal byte[] window;

        internal int window_size;

        internal DeflateManager()
        {
        }

        internal bool WantRfc1950HeaderBytes
        {
            get { return false; }
            set { }
        }

        private void _InitializeLazyMatch()
        {
        }

        private void _InitializeTreeData()
        {
        }

        internal void _InitializeBlocks()
        {
        }

        internal void pqdownheap(short[] tree, int k)
        {
        }

        internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
        {
            return false;
        }

        internal void scan_tree(short[] tree, int max_code)
        {
        }

        internal int build_bl_tree()
        {
            return 0;
        }

        internal void send_all_trees(int lcodes, int dcodes, int blcodes)
        {
        }

        internal void send_tree(short[] tree, int max_code)
        {
        }

        private void put_bytes(byte[] p, int start, int len)
        {
        }

        internal void send_code(int c, short[] tree)
        {
        }

        internal void send_bits(int value, int length)
        {
        }

        internal void _tr_align()
        {
        }

        internal bool _tr_tally(int dist, int lc)
        {
            return false;
        }

        internal void send_compressed_block(short[] ltree, short[] dtree)
        {
        }

        internal void set_data_type()
        {
        }

        internal void bi_flush()
        {
        }

        internal void bi_windup()
        {
        }

        internal void copy_block(int buf, int len, bool header)
        {
        }

        internal void flush_block_only(bool eof)
        {
        }

        internal BlockState DeflateNone(FlushType flush)
        {
            return default(BlockState);
        }

        internal void _tr_stored_block(int buf, int stored_len, bool eof)
        {
        }

        internal void _tr_flush_block(int buf, int stored_len, bool eof)
        {
        }

        private void _fillWindow()
        {
        }

        internal BlockState DeflateFast(FlushType flush)
        {
            return default(BlockState);
        }

        internal BlockState DeflateSlow(FlushType flush)
        {
            return default(BlockState);
        }

        internal int longest_match(int cur_match)
        {
            return 0;
        }

        internal int Initialize(ZlibCodec codec, CompressionLevel level)
        {
            return 0;
        }

        internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
        {
            return 0;
        }

        internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits,
            CompressionStrategy compressionStrategy)
        {
            return 0;
        }

        internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel,
            CompressionStrategy strategy)
        {
            return 0;
        }

        internal void Reset()
        {
        }

        internal int End()
        {
            return 0;
        }

        private void SetDeflater()
        {
        }

        internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
        {
            return 0;
        }

        internal int SetDictionary(byte[] dictionary)
        {
            return 0;
        }

        internal int Deflate(FlushType flush)
        {
            return 0;
        }

        internal delegate BlockState CompressFunc(FlushType flush);

        internal class Config
        {
            private static readonly Config[] Table;

            internal DeflateFlavor Flavor;
            internal int GoodLength;

            internal int MaxChainLength;

            internal int MaxLazy;

            internal int NiceLength;

            static Config()
            {
            }

            private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
            {
            }

            public static Config Lookup(CompressionLevel level)
            {
                return null;
            }
        }
    }
}