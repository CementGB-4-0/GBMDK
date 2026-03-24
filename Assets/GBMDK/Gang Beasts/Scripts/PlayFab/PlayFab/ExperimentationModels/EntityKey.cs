using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class EntityKey : PlayFabBaseModel
    {
        public string Id;

        public string Type;
    }
}