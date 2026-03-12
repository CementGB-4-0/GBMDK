using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class WindowsCrashDumpConfiguration : PlayFabBaseModel
    {
        public bool IsEnabled;
        public int? CustomDumpFlags;

        public int? DumpType;
    }
}