using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class EntityKey : PlayFabBaseModel
    {
        public string Id;

        public string Type;
    }
}