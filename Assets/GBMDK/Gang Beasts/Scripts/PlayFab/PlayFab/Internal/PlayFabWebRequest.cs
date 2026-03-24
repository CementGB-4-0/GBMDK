using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace PlayFab.Internal
{
    public class PlayFabWebRequest : ITransportPlugin, IPlayFabPlugin
    {
        private static readonly Queue<Action> ResultQueueTransferThread;

        private static readonly Queue<Action> ResultQueueMainThread;

        private static readonly List<CallRequestContainer> ActiveRequests;

        private static bool certValidationSet;

        private static Thread _requestQueueThread;

        private static readonly object _ThreadLock;

        private static readonly TimeSpan ThreadKillTimeout;

        private static DateTime _threadKillTime;

        private static bool _isApplicationPlaying;

        private static int _activeCallCount;

        private static string _unityVersion;

        private bool _isInitialized;

        public static RemoteCertificateValidationCallback CustomCertValidationHook
        {
            set { }
        }

        public bool IsInitialized => false;

        public void Initialize()
        {
        }

        public void OnDestroy()
        {
        }

        public void SimpleGetCall(string fullUrl, Action<byte[]> successCallback, Action<string> errorCallback)
        {
        }

        public void SimplePutCall(string fullUrl, byte[] payload, Action<byte[]> successCallback,
            Action<string> errorCallback)
        {
        }

        public void SimplePostCall(string fullUrl, byte[] payload, Action<byte[]> successCallback,
            Action<string> errorCallback)
        {
        }

        public void MakeApiCall(object reqContainerObj)
        {
        }

        public void Update()
        {
        }

        public int GetPendingMessages()
        {
            return 0;
        }

        public static void SkipCertificateValidation()
        {
        }

        private void SetupCertificates()
        {
        }

        private static bool AcceptAllCertifications(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            return false;
        }

        private void SimpleHttpsWorker(string httpMethod, string fullUrl, byte[] payload,
            Action<byte[]> successCallback, Action<string> errorCallback)
        {
        }

        private static void ActivateThreadWorker()
        {
        }

        private static void WorkerThreadMainLoop()
        {
        }

        private static void Post(CallRequestContainer reqContainer)
        {
        }

        private static void ProcessHttpResponse(CallRequestContainer reqContainer)
        {
        }

        private static void QueueRequestError(CallRequestContainer reqContainer)
        {
        }

        private static void ProcessJsonResponse(CallRequestContainer reqContainer)
        {
        }

        private static string ResponseToString(WebResponse webResponse)
        {
            return null;
        }
    }
}