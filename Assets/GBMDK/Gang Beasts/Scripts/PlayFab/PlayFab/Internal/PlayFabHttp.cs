using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PlayFab.Public;
using PlayFab.SharedModels;
using UnityEngine;

namespace PlayFab.Internal
{
    public class PlayFabHttp : SingletonMonoBehaviour<PlayFabHttp>
    {
        public delegate void ApiProcessErrorEvent(PlayFabRequestCommon request, PlayFabError error);

        public delegate void ApiProcessingEvent<in TEventArgs>(TEventArgs e);

        private const float delayBetweenBatches = 5f;

        private static List<CallRequestContainer> _apiCallQueue;

        public static readonly Dictionary<string, string> GlobalHeaderInjection;

        private static IPlayFabLogger _logger;

        private static IScreenTimeTracker screenTimeTracker;

        private readonly Queue<Action> _injectedAction;

        private readonly Queue<IEnumerator> _injectedCoroutines;

        private void Update()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        public void OnApplicationFocus(bool isFocused)
        {
        }

        public void OnApplicationQuit()
        {
        }

        public static event ApiProcessingEvent<ApiProcessingEventArgs> ApiProcessingEventHandler
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event ApiProcessErrorEvent ApiProcessingErrorEventHandler
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static int GetPendingMessages()
        {
            return 0;
        }

        public static void InitializeHttp()
        {
        }

        public static void InitializeLogger(IPlayFabLogger setLogger = null)
        {
        }

        public static void InitializeScreenTimeTracker(string entityId, string entityType, string playFabUserId)
        {
        }

        [IteratorStateMachine(typeof(_003CSendScreenTimeEvents_003Ed__17))]
        private static IEnumerator SendScreenTimeEvents(float secondsBetweenBatches)
        {
            return null;
        }

        public static void SimpleGetCall(string fullUrl, Action<byte[]> successCallback, Action<string> errorCallback)
        {
        }

        public static void SimplePutCall(string fullUrl, byte[] payload, Action<byte[]> successCallback,
            Action<string> errorCallback)
        {
        }

        public static void SimplePostCall(string fullUrl, byte[] payload, Action<byte[]> successCallback,
            Action<string> errorCallback)
        {
        }

        protected internal static void MakeApiCall<TResult>(string apiEndpoint, PlayFabRequestCommon request,
            AuthType authType, Action<TResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null,
            PlayFabAuthenticationContext authenticationContext = null, PlayFabApiSettings apiSettings = null,
            IPlayFabInstanceApi instanceApi = null) where TResult : PlayFabResultCommon
        {
        }

        protected internal static void MakeApiCallWithFullUri<TResult>(string fullUri, PlayFabRequestCommon request,
            AuthType authType, Action<TResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null,
            PlayFabAuthenticationContext authenticationContext = null, PlayFabApiSettings apiSettings = null,
            IPlayFabInstanceApi instanceApi = null) where TResult : PlayFabResultCommon
        {
        }

        private static void _MakeApiCall<TResult>(string apiEndpoint, string fullUrl, PlayFabRequestCommon request,
            AuthType authType, Action<TResult> resultCallback, Action<PlayFabError> errorCallback, object customData,
            Dictionary<string, string> extraHeaders, bool allowQueueing,
            PlayFabAuthenticationContext authenticationContext, PlayFabApiSettings apiSettings,
            IPlayFabInstanceApi instanceApi) where TResult : PlayFabResultCommon
        {
        }

        internal void OnPlayFabApiResult(CallRequestContainer reqContainer)
        {
        }

        protected internal static PlayFabError GeneratePlayFabError(string apiEndpoint, string json, object customData)
        {
            return null;
        }

        protected internal static void SendErrorEvent(PlayFabRequestCommon request, PlayFabError error)
        {
        }

        protected internal static void SendEvent(string apiEndpoint, PlayFabRequestCommon request,
            PlayFabResultCommon result, ApiProcessingEventType eventType)
        {
        }

        public static void ClearAllEvents()
        {
        }

        public void InjectInUnityThread(IEnumerator x)
        {
        }

        public void InjectInUnityThread(Action action)
        {
        }

        [CompilerGenerated]
        private sealed class _003CSendScreenTimeEvents_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;

            private object _003C_003E2__current;

            private WaitForSeconds _003Cdelay_003E5__2;

            public float secondsBetweenBatches;

            [DebuggerHidden]
            public _003CSendScreenTimeEvents_003Ed__17(int _003C_003E1__state)
            {
            }

            object IEnumerator<object>.Current
            {
                [DebuggerHidden] get { return null; }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden] get { return null; }
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }

            bool IEnumerator.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                return this.MoveNext();
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
            }

            private bool MoveNext()
            {
                return false;
            }
        }
    }
}