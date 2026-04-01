using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class OverrideUnsignedInt : PlayFabBaseModel
    {
        public uint Value;
    }
}