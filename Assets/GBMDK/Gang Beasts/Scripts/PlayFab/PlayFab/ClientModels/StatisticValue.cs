using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class StatisticValue : PlayFabBaseModel
    {
        public string StatisticName;

        public int Value;

        public uint Version;
    }
}