using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class PlayerStatisticVersion : PlayFabBaseModel
    {
        public string StatisticName;

        public uint Version;
        public DateTime ActivationTime;

        public DateTime? DeactivationTime;

        public DateTime? ScheduledActivationTime;

        public DateTime? ScheduledDeactivationTime;
    }
}