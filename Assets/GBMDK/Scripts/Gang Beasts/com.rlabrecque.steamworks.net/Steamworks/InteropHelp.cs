using System;
using Microsoft.Win32.SafeHandles;

namespace Steamworks
{
	public class InteropHelp
	{
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			public UTF8StringHandle(string str)
				: base(ownsHandle: false)
			{
			}

			protected override bool ReleaseHandle()
			{
				return false;
			}
		}

		public static void TestIfPlatformSupported()
		{
		}

		public static void TestIfAvailableClient()
		{
		}

		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}
	}
}
