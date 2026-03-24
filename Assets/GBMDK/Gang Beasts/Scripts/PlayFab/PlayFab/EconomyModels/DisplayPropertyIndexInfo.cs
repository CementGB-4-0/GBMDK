using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class DisplayPropertyIndexInfo : PlayFabBaseModel
    {
        public string Name;

        public DisplayPropertyType? Type;
    }
}