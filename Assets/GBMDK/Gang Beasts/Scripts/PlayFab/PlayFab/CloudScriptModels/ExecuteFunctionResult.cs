using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ExecuteFunctionResult : PlayFabResultCommon
    {
        public FunctionExecutionError Error;

        public int ExecutionTimeMilliseconds;

        public string FunctionName;

        public object FunctionResult;

        public bool? FunctionResultTooLarge;
    }
}