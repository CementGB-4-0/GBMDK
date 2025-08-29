using System.Runtime.InteropServices;
using SuperGenius.Lib.Burst.Easing;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.Random
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[BurstCompile]
	public struct RandomPointsMinMaxRadius
	{
		[BurstCompile]
		private struct CellLocation
		{
			public int Index;

			public int X;

			public int Y;

			public int Z;

			public CellLocation(int index, int x, int y, int z)
			{
				Index = 0;
				X = 0;
				Y = 0;
				Z = 0;
			}
		}

		public static void BuildRandomList([Unity.Collections.ReadOnly] uint RandomSeed, [Unity.Collections.ReadOnly] float MinRadius, [Unity.Collections.ReadOnly] float MaxRadius, [Unity.Collections.ReadOnly] int MaxPoints, [Unity.Collections.ReadOnly] EaseFuctions.EaseType easeType, [Unity.Collections.ReadOnly] bool SkipSafetyCheck, [Unity.Collections.ReadOnly] ref Bounds Bounds, [WriteOnly] ref NativeList<float3> RandomPositions)
		{
		}

		public static void GridSafetyCheck(ref float MinRadius, float MaxRadius, float3 size)
		{
		}

		private static int GetCellAt(int x, int y, int z, int yLength, int zLength)
		{
			return 0;
		}
	}
}
