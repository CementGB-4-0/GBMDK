using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class FunctionModel : PlayFabBaseModel
    {
        public string FunctionAddress;

        public string FunctionName;

        public string TriggerType;
    }
}