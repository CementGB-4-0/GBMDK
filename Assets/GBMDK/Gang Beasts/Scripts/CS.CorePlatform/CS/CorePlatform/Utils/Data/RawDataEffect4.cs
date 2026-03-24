using System.Runtime.InteropServices;

namespace CS.CorePlatform.Utils.Data
{
    [StructLayout((LayoutKind)2)]
    public struct RawDataEffect4
    {
        [FieldOffset(0)] public uint UInt;

        [FieldOffset(0)] public int Int;

        [FieldOffset(0)] public float Float;

        [FieldOffset(0)] public char Char;

        [FieldOffset(0)] private ushort _0uShort;

        [FieldOffset(2)] private ushort _1uShort;

        [FieldOffset(0)] private short _0Short;

        [FieldOffset(2)] private short _1Short;

        [FieldOffset(0)] private byte _0Byte;

        [FieldOffset(1)] private byte _1Byte;

        [FieldOffset(2)] private byte _2Byte;

        [FieldOffset(3)] private byte _3Byte;

        [FieldOffset(0)] private sbyte _0sByte;

        [FieldOffset(1)] private sbyte _1sByte;

        [FieldOffset(2)] private sbyte _2sByte;

        [FieldOffset(3)] private sbyte _3sByte;

        public short Short
        {
            get { return 0; }
            set { }
        }

        public ushort UShort
        {
            get { return 0; }
            set { }
        }

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