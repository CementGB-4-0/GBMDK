using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ServerResourceConstraintParams : PlayFabBaseModel
    {
        public double CpuLimit;

        public double MemoryLimitGB;
    }
}