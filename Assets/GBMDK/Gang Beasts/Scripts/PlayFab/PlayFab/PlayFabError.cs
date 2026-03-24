using System;
using System.Collections.Generic;
using System.Text;

namespace PlayFab
{
    public class PlayFabError
    {
        [ThreadStatic] private static StringBuilder _tempSb;

        public string ApiEndpoint;

        public object CustomData;

        public PlayFabErrorCode Error;

        public Dictionary<string, List<string>> ErrorDetails;

        public string ErrorMessage;

        public int HttpCode;

        public string HttpStatus;

        public uint? RetryAfterSeconds;

        public override string ToString()
        {
            return null;
        }

        public string GenerateErrorReport()
        {
            return null;
        }
    }
}