using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class DynamicStandbyThreshold : PlayFabBaseModel
    {
        public double Multiplier;

        public double TriggerThresholdPercentage;
    }
}