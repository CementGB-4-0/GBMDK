using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.MeshModification
{
	public class MeshTransformJob
	{
		public static JobHandle CreateJob(ref MeshData meshData, float3 position, quaternion rotation, float3 scale)
		{
			return default(JobHandle);
		}
	}
}
