using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class LinuxInstrumentationConfiguration : PlayFabBaseModel
    {
        public bool IsEnabled;
    }
}