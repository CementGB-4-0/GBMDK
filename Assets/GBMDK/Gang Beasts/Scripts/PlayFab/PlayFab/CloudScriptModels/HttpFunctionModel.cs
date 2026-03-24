using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class HttpFunctionModel : PlayFabBaseModel
    {
        public string FunctionName;

        public string FunctionUrl;
    }
}