using System;
using System.Collections.Generic;
using System.Net;
using PlayFab.SharedModels;

namespace PlayFab.Internal
{
    public class CallRequestContainer
    {
        public string ApiEndpoint;

        public PlayFabRequestCommon ApiRequest;

        public PlayFabResultCommon ApiResult;

        public bool CalledGetResponse;

        public PlayFabAuthenticationContext context;

        public object CustomData;

        public Action DeserializeResultJson;

        public PlayFabError Error;

        public Action<PlayFabError> ErrorCallback;

        public string FullUrl;

        public HttpWebRequest HttpRequest;
        public HttpRequestState HttpState;

        public IPlayFabInstanceApi instanceApi;

        public Action InvokeSuccessCallback;

        public string JsonResponse;

        public byte[] Payload;

        public Dictionary<string, string> RequestHeaders;

        public PlayFabApiSettings settings;
    }
}