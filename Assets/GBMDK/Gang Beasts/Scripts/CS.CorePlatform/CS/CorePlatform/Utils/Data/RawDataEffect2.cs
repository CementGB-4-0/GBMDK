using System.Runtime.InteropServices;

namespace CS.CorePlatform.Utils.Data
{
    [StructLayout((LayoutKind)2)]
    public struct RawDataEffect2
    {
        [FieldOffset(0)] public ushort UShort;

        [FieldOffset(0)] public short Short;

        [FieldOffset(0)] private byte _0Byte;

        [FieldOffset(1)] private byte _1Byte;

        [FieldOffset(0)] private sbyte _0sByte;

        [FieldOffset(1)] private sbyte _1sByte;

        public byte Byte
        {
            get { return 0; }
            set { }
        }

        public sbyte SByte
        {
            get { return 0; }
            set { }
        }
    }
}