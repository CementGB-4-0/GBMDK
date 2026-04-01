using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class OverrideDouble : PlayFabBaseModel
    {
        public double Value;
    }
}