using System.Runtime.InteropServices;
using GB.Networking.Objects;
using UnityEngine.Networking;

namespace Unity
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	public class GeneratedNetworkCode
	{
		public static void _WriteArrayUInt64_None(NetworkWriter writer, ulong[] value)
		{
		}

		public static ulong[] _ReadArrayUInt64_None(NetworkReader reader)
		{
			return null;
		}

		public static void _WriteNetCostumeCloudData_None(NetworkWriter writer, NetCostumeCloudData value)
		{
		}

		public static void _WriteNetCostumeArticle_None(NetworkWriter writer, NetCostumeArticle value)
		{
		}

		public static void _WriteArrayNetCostumeArticle_None(NetworkWriter writer, NetCostumeArticle[] value)
		{
		}

		public static NetCostumeCloudData _ReadNetCostumeCloudData_None(NetworkReader reader)
		{
			return null;
		}

		public static NetCostumeArticle _ReadNetCostumeArticle_None(NetworkReader reader)
		{
			return null;
		}

		public static NetCostumeArticle[] _ReadArrayNetCostumeArticle_None(NetworkReader reader)
		{
			return null;
		}
	}
}
