using System;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class EntityStatisticChildValue : PlayFabBaseModel
    {
        public string ChildName;

        public string Metadata;

        public int Value;
    }
}