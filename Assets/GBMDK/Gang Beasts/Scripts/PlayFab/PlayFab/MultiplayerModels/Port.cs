using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class Port : PlayFabBaseModel
    {
        public string Name;

        public int Num;

        public ProtocolType Protocol;
    }
}