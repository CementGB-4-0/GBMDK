using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class Schedule : PlayFabBaseModel
    {
        public string Description;

        public bool IsDisabled;

        public bool IsRecurringWeekly;

        public int TargetStandby;

        public DateTime EndTime;

        public DateTime StartTime;
    }
}