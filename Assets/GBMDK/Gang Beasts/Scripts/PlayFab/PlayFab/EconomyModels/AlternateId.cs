using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class AlternateId : PlayFabBaseModel
    {
        public string Type;

        public string Value;
    }
}