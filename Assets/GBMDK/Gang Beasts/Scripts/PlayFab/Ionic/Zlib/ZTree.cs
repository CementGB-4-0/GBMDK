namespace Ionic.Zlib
{
    internal sealed class ZTree
    {
        internal const int Buf_size = 16;
        private static readonly int HEAP_SIZE;

        internal static readonly int[] ExtraLengthBits;

        internal static readonly int[] ExtraDistanceBits;

        internal static readonly int[] extra_blbits;

        internal static readonly sbyte[] bl_order;

        private static readonly sbyte[] _dist_code;

        internal static readonly sbyte[] LengthCode;

        internal static readonly int[] LengthBase;

        internal static readonly int[] DistanceBase;

        internal short[] dyn_tree;

        internal int max_code;

        internal StaticTree staticTree;

        internal static int DistanceCode(int dist)
        {
            return 0;
        }

        internal void gen_bitlen(DeflateManager s)
        {
        }

        internal void build_tree(DeflateManager s)
        {
        }

        internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
        {
        }

        internal static int bi_reverse(int code, int len)
        {
            return 0;
        }
    }
}