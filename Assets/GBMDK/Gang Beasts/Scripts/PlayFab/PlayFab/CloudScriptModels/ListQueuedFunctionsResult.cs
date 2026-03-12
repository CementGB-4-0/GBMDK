using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ListQueuedFunctionsResult : PlayFabResultCommon
    {
        public List<QueuedFunctionModel> Functions;
    }
}