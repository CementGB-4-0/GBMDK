using System;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
    [Serializable]
    public class EntityKey : PlayFabBaseModel
    {
        public string Id;

        public string Type;
    }
}