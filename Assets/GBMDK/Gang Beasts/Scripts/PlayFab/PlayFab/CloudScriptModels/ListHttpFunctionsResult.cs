using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ListHttpFunctionsResult : PlayFabResultCommon
    {
        public List<HttpFunctionModel> Functions;
    }
}