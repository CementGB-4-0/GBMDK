using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CurrentServerStats : PlayFabBaseModel
    {
        public int Active;

        public int Propping;

        public int StandingBy;

        public int Total;
    }
}