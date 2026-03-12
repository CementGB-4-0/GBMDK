using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class StatisticNameVersion : PlayFabBaseModel
    {
        public string StatisticName;

        public uint Version;
    }
}