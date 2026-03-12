using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ListFunctionsResult : PlayFabResultCommon
    {
        public List<FunctionModel> Functions;
    }
}