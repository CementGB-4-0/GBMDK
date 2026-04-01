using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class TreatmentAssignment : PlayFabBaseModel
    {
        public List<Variable> Variables;

        public List<string> Variants;
    }
}