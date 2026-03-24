using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class EntityKey : PlayFabBaseModel
    {
        public string Id;

        public string Type;
    }
}