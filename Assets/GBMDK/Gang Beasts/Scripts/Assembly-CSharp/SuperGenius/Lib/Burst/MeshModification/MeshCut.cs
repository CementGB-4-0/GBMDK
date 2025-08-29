using System.Runtime.InteropServices;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.MeshModification
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[BurstCompile]
	public struct MeshCut
	{
		public static void PlantCutAndFill([Unity.Collections.ReadOnly] ref MeshData uncutMesh, ref MeshData cutMesh, [Unity.Collections.ReadOnly] ref Plane cutPlane, int fillSubMesh = 0)
		{
		}

		public static void PlaneCut([Unity.Collections.ReadOnly] ref MeshData uncutMesh, ref MeshData cutMesh, [Unity.Collections.ReadOnly] ref Plane cutPlane)
		{
		}

		public static void FillHole(ref MeshData cutMesh, float3 normal, int subMesh = 0)
		{
		}

		private static void AddTriangle([Unity.Collections.ReadOnly] ref MeshData readLocation, [WriteOnly] ref MeshData writeLocation, int index0, int index1, int index2)
		{
		}

		private static float3 VertToPlane([Unity.Collections.ReadOnly] ref Plane plane, int vert0Index, int vert1Index, [Unity.Collections.ReadOnly] ref MeshData readLocation, [WriteOnly] ref MeshData writeLocation)
		{
			return default(float3);
		}
	}
}
