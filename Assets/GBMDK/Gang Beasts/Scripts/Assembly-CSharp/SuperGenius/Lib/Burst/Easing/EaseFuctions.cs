using System.Runtime.InteropServices;
using Unity.Burst;

namespace SuperGenius.Lib.Burst.Easing
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[BurstCompile]
	public struct EaseFuctions
	{
		public enum EaseType
		{
			None = 0,
			EaseInSine = 1,
			EaseOutSine = 2,
			EaseInOutSine = 3,
			EaseInQuad = 4,
			EaseOutQuad = 5,
			EaseInOutQuad = 6,
			EaseInCubic = 7,
			EaseOutCubic = 8,
			EaseInOutCubic = 9,
			EaseInQuint = 10,
			EaseOutQuint = 11,
			EaseInOutQuint = 12
		}

		public static float Ease(EaseType type, float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInSine(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseOutSine(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInOutSine(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInQuad(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseOutQuad(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInOutQuad(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInCubic(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseOutCubic(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInOutCubic(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInQuint(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseOutQuint(float min, float max, float alpha)
		{
			return 0f;
		}

		public static float EaseInOutQuint(float min, float max, float alpha)
		{
			return 0f;
		}
	}
}
