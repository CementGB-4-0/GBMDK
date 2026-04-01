using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class Variant : PlayFabBaseModel
    {
        public string Description;

        public string Id;

        public bool IsControl;

        public string Name;

        public string TitleDataOverrideLabel;

        public uint TrafficPercentage;

        public List<Variable> Variables;
    }
}