using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
    [Serializable]
    public class TreatmentAssignment : PlayFabBaseModel
    {
        public List<Variable> Variables;

        public List<string> Variants;
    }
}