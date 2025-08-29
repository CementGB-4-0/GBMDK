using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Mathematics;

[StructLayout((LayoutKind)0, Size = 1)]
[BurstCompile]
public struct GertsnerHelpers
{
	public delegate void VectorSin_00000BEA_0024PostfixBurstDelegate(in float4 v, out float4 vSin);

	internal static class VectorSin_00000BEA_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public static void Invoke(in float4 v, out float4 vSin)
		{
			vSin = default(float4);
		}
	}

	public delegate void VectorCos_00000BEB_0024PostfixBurstDelegate(in float4 v, out float4 vCos);

	internal static class VectorCos_00000BEB_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public static void Invoke(in float4 v, out float4 vCos)
		{
			vCos = default(float4);
		}
	}

	public delegate void GerstnerOffset4_00000BEC_0024PostfixBurstDelegate(in float2 xzVtx, in float4 steepness, in float4 amp, in float4 freq, in float4 speed, in float4 dirAB, in float4 dirCD, out float3 offsets);

	internal static class GerstnerOffset4_00000BEC_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public static void Invoke(in float2 xzVtx, in float4 steepness, in float4 amp, in float4 freq, in float4 speed, in float4 dirAB, in float4 dirCD, out float3 offsets)
		{
			offsets = default(float3);
		}
	}

	public delegate void GetWavePosition_00000BED_0024PostfixBurstDelegate(in float2 position, in float2 time, float fadeStart, float fadeEnd, float waveCount, float waveDistance, in float4 waveDirection, float waveSteepness, int maxWaveCount, in float3 cameraPos, out float3 wavePosOut);

	internal static class GetWavePosition_00000BED_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public static void Invoke(in float2 position, in float2 time, float fadeStart, float fadeEnd, float waveCount, float waveDistance, in float4 waveDirection, float waveSteepness, int maxWaveCount, in float3 cameraPos, out float3 wavePosOut)
		{
			wavePosOut = default(float3);
		}
	}

	[BurstCompile]
	private static void VectorSin(in float4 v, out float4 vSin)
	{
		vSin = default(float4);
	}

	[BurstCompile]
	private static void VectorCos(in float4 v, out float4 vCos)
	{
		vCos = default(float4);
	}

	[BurstCompile]
	private static void GerstnerOffset4(in float2 xzVtx, in float4 steepness, in float4 amp, in float4 freq, in float4 speed, in float4 dirAB, in float4 dirCD, out float3 offsets)
	{
		offsets = default(float3);
	}

	[BurstCompile]
	public static void GetWavePosition(in float2 position, in float2 time, float fadeStart, float fadeEnd, float waveCount, float waveDistance, in float4 waveDirection, float waveSteepness, int maxWaveCount, in float3 cameraPos, out float3 wavePosOut)
	{
		wavePosOut = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	public static void VectorSin_0024BurstManaged(in float4 v, out float4 vSin)
	{
		vSin = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	public static void VectorCos_0024BurstManaged(in float4 v, out float4 vCos)
	{
		vCos = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	public static void GerstnerOffset4_0024BurstManaged(in float2 xzVtx, in float4 steepness, in float4 amp, in float4 freq, in float4 speed, in float4 dirAB, in float4 dirCD, out float3 offsets)
	{
		offsets = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	public static void GetWavePosition_0024BurstManaged(in float2 position, in float2 time, float fadeStart, float fadeEnd, float waveCount, float waveDistance, in float4 waveDirection, float waveSteepness, int maxWaveCount, in float3 cameraPos, out float3 wavePosOut)
	{
		wavePosOut = default(float3);
	}
}
