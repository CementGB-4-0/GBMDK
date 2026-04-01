using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Crc
{
    [Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    public class CRC32
    {
        private const int BUFFER_SIZE = 8192;

        private uint _register;

        private long _TotalBytesRead;

        private uint[] crc32Table;
        private uint dwPolynomial;

        private bool reverseBits;

        public CRC32()
        {
        }

        public CRC32(bool reverseBits)
        {
        }

        public CRC32(int polynomial, bool reverseBits)
        {
        }

        public long TotalBytesRead => 0L;

        public int Crc32Result => 0;

        public int GetCrc32(Stream input)
        {
            return 0;
        }

        public int GetCrc32AndCopy(Stream input, Stream output)
        {
            return 0;
        }

        public int ComputeCrc32(int W, byte B)
        {
            return 0;
        }

        internal int _InternalComputeCrc32(uint W, byte B)
        {
            return 0;
        }

        public void SlurpBlock(byte[] block, int offset, int count)
        {
        }

        public void UpdateCRC(byte b)
        {
        }

        public void UpdateCRC(byte b, int n)
        {
        }

        private static uint ReverseBits(uint data)
        {
            return 0u;
        }

        private static byte ReverseBits(byte data)
        {
            return 0;
        }

        private void GenerateLookupTable()
        {
        }

        private uint gf2_matrix_times(uint[] matrix, uint vec)
        {
            return 0u;
        }

        private void gf2_matrix_square(uint[] square, uint[] mat)
        {
        }

        public void Combine(int crc, int length)
        {
        }

        public void Reset()
        {
        }
    }
}