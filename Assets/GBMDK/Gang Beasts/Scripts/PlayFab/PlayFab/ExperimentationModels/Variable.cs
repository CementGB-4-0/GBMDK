using System;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class Variable : PlayFabBaseModel
    {
        public string Name;

        public string Value;
    }
}