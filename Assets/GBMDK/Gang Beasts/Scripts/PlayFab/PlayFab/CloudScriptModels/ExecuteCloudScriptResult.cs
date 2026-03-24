using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class ExecuteCloudScriptResult : PlayFabResultCommon
    {
        public int APIRequestsIssued;

        public ScriptExecutionError Error;

        public double ExecutionTimeSeconds;

        public string FunctionName;

        public int HttpRequestsIssued;

        public List<LogStatement> Logs;

        public uint MemoryConsumedBytes;

        public double ProcessorTimeSeconds;

        public int Revision;

        public object FunctionResult;

        public bool? FunctionResultTooLarge;

        public bool? LogsTooLarge;
    }
}