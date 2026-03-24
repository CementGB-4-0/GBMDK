using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ScheduledStandbySettings : PlayFabBaseModel
    {
        public bool IsEnabled;

        public List<Schedule> ScheduleList;
    }
}