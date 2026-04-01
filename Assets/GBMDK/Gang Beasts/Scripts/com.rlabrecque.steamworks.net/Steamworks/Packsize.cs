using System.Runtime.InteropServices;

namespace Steamworks
{
    public static class Packsize
    {
        public static bool Test()
        {
            return false;
        }

        [StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
        private struct ValvePackingSentinel_t
        {
            private uint m_u32;

            private ulong m_u64;

            private ushort m_u16;

            private double m_d;
        }
    }
}