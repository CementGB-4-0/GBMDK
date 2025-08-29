using System;
using System.Runtime.InteropServices;

namespace Coatsink.Common
{
	[StructLayout((LayoutKind)2)]
	public struct primitive
	{
		[FieldOffset(0)]
		public bool bl;

		[FieldOffset(0)]
		public char ch;

		[FieldOffset(0)]
		public byte u1;

		[FieldOffset(0)]
		public ushort u2;

		[FieldOffset(0)]
		public uint u4;

		[FieldOffset(0)]
		public ulong u8;

		[FieldOffset(0)]
		public sbyte s1;

		[FieldOffset(0)]
		public short s2;

		[FieldOffset(0)]
		public int s4;

		[FieldOffset(0)]
		public long s8;

		[FieldOffset(0)]
		public float f4;

		[FieldOffset(0)]
		public double f8;

		[FieldOffset(0)]
		public bool b_0;

		[FieldOffset(1)]
		public bool b_1;

		[FieldOffset(2)]
		public bool b_2;

		[FieldOffset(3)]
		public bool b_3;

		[FieldOffset(4)]
		public bool b_4;

		[FieldOffset(5)]
		public bool b_5;

		[FieldOffset(6)]
		public bool b_6;

		[FieldOffset(7)]
		public bool b_7;

		[FieldOffset(0)]
		public byte u1_0;

		[FieldOffset(1)]
		public byte u1_1;

		[FieldOffset(2)]
		public byte u1_2;

		[FieldOffset(3)]
		public byte u1_3;

		[FieldOffset(4)]
		public byte u1_4;

		[FieldOffset(5)]
		public byte u1_5;

		[FieldOffset(6)]
		public byte u1_6;

		[FieldOffset(7)]
		public byte u1_7;

		[FieldOffset(0)]
		public int s4_0;

		[FieldOffset(4)]
		public int s4_1;

		public void Set(object obj, TypeCode code)
		{
		}

		public TypeCode Set(object obj)
		{
			return default(TypeCode);
		}

		public TypeCode TrySet(object obj)
		{
			return default(TypeCode);
		}

		public string ToString(TypeCode code, string format = null)
		{
			return null;
		}

		public object Get(TypeCode code)
		{
			return null;
		}
	}
}
