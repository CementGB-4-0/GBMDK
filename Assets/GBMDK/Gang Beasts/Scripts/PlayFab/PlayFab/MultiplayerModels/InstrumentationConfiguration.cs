using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class InstrumentationConfiguration : PlayFabBaseModel
    {
        public List<string> ProcessesToMonitor;
        public bool? IsEnabled;
    }
}