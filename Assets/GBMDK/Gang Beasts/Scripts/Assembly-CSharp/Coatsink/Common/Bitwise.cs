using System.Runtime.InteropServices;
using UnityEngine;

namespace Coatsink.Common
{
	public static class Bitwise
	{
		[StructLayout((LayoutKind)2)]
		public struct TypeUnion
		{
			[FieldOffset(0)]
			public int Int32Bits;

			[FieldOffset(0)]
			public float FloatBits;
		}

		public static long IntsToLong(int msbs, int lsbs)
		{
			return 0L;
		}

		public static void LongToInts(long theLong, out int msbs, out int lsbs)
		{
			msbs = default(int);
			lsbs = default(int);
		}

		public static int BitRotate_u32(int value, int shift)
		{
			return 0;
		}

		public static int BitRotate_u16(int value, int shift)
		{
			return 0;
		}

		public static int BitRotate_u8(int value, int shift)
		{
			return 0;
		}

		public static float PackVector2ToFloat(Vector2 input, float scale = 10000f)
		{
			return 0f;
		}

		public static Vector2 UnPackFloatToVector2(float input, float scale = 10000f)
		{
			return default(Vector2);
		}

		public static int PackVector2ToInt32(Vector2 v)
		{
			return 0;
		}

		public static Vector2 UnpackInt32ToVector2(int v)
		{
			return default(Vector2);
		}
	}
}
