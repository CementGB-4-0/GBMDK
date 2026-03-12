using System.Runtime.InteropServices;

namespace CS.CorePlatform.Utils.Data
{
    [StructLayout((LayoutKind)2)]
    public struct RawDataEffect8
    {
        [FieldOffset(0)] public long Long;

        [FieldOffset(0)] public ulong ULong;

        [FieldOffset(0)] public double Double;

        [FieldOffset(0)] private uint _0uInt;

        [FieldOffset(4)] private uint _1uInt;

        [FieldOffset(0)] private int _0Int;

        [FieldOffset(4)] private int _1Int;

        [FieldOffset(0)] private float _0Float;

        [FieldOffset(4)] private float _1Float;

        [FieldOffset(0)] private ushort _0uShort;

        [FieldOffset(2)] private ushort _1uShort;

        [FieldOffset(4)] private ushort _2uShort;

        [FieldOffset(6)] private ushort _3uShort;

        [FieldOffset(0)] private short _0Short;

        [FieldOffset(2)] private short _1Short;

        [FieldOffset(4)] private short _2Short;

        [FieldOffset(6)] private short _3Short;

        [FieldOffset(0)] private char _0Char;

        [FieldOffset(2)] private char _1Char;

        [FieldOffset(4)] private char _2Char;

        [FieldOffset(6)] private char _3Char;

        [FieldOffset(0)] private byte _0Byte;

        [FieldOffset(1)] private byte _1Byte;

        [FieldOffset(2)] private byte _2Byte;

        [FieldOffset(3)] private byte _3Byte;

        [FieldOffset(4)] private byte _4Byte;

        [FieldOffset(5)] private byte _5Byte;

        [FieldOffset(6)] private byte _6Byte;

        [FieldOffset(7)] private byte _7Byte;

        [FieldOffset(0)] private sbyte _0sByte;

        [FieldOffset(1)] private sbyte _1sByte;

        [FieldOffset(2)] private sbyte _2sByte;

        [FieldOffset(3)] private sbyte _3sByte;

        [FieldOffset(4)] private sbyte _4sByte;

        [FieldOffset(5)] private sbyte _5sByte;

        [FieldOffset(6)] private sbyte _6sByte;

        [FieldOffset(7)] private sbyte _7sByte;

        public uint UInt
        {
            get { return 0u; }
            set { }
        }

        public int Int
        {
            get { return 0; }
            set { }
        }

        public float Float
        {
            get { return 0f; }
            set { }
        }

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

        public char Char
        {
            get { return '\0'; }
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