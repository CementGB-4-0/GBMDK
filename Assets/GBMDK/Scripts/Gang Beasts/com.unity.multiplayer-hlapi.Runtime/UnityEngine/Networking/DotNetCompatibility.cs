using System;
using System.Net.Sockets;

namespace UnityEngine.Networking
{
	internal static class DotNetCompatibility
	{
		internal static string GetMethodName(this Delegate func)
		{
			return null;
		}

		internal static Type GetBaseType(this Type type)
		{
			return null;
		}

		internal static string GetErrorCode(this SocketException e)
		{
			return null;
		}
	}
}
