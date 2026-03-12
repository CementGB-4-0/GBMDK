using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class DynamicStandbySettings : PlayFabBaseModel
    {
        public List<DynamicStandbyThreshold> DynamicFloorMultiplierThresholds;

        public bool IsEnabled;

        public int? RampDownSeconds;
    }
}