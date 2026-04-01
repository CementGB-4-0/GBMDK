using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class StatisticModel : PlayFabBaseModel
    {
        public string Name;

        public int Value;

        public int Version;
    }
}