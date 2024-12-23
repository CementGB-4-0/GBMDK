using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class WindowsCrashDumpConfiguration : PlayFabBaseModel
	{
		public int? CustomDumpFlags;

		public int? DumpType;

		public bool IsEnabled;
	}
}
