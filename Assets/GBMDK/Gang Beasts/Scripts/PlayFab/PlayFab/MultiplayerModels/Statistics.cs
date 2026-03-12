using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class Statistics : PlayFabBaseModel
    {
        public double Average;

        public double Percentile50;

        public double Percentile90;

        public double Percentile99;
    }
}