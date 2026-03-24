using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PlayFab.AuthenticationModels;
using PlayFab.EventsModels;
using PlayFab.Internal;
using UnityEngine;
using EntityKey = PlayFab.EventsModels.EntityKey;

namespace PlayFab.Party
{
    internal sealed class PlayFabEventTracer : SingletonMonoBehaviour<PlayFabEventTracer>
    {
        private const string eventNamespace = "playfab.party";

        private const float delayBetweenEntityLoggedIn = 5f;

        private const int maxBatchSizeInEvents = 10;

        private EntityKey entityKey;

        private PlayFabEventsInstanceAPI eventApi;

        private Queue<EventContents> eventsPending;

        private Queue<EventContents> eventsRequests;

        private Guid gameSessionID;

        private long lastErrorTimeInMillisecond;

        private int retryCount;

        private PlayFabEventTracer()
        {
        }

        public void OnEnable()
        {
        }

        public void OnDisable()
        {
        }

        public void OnDestroy()
        {
        }

        private void SetCommonTelemetryProperties(Dictionary<string, object> payload)
        {
        }

        private static long GetCurrentTimeInMilliseconds()
        {
            return 0L;
        }

        public void OnPlayFabMultiPlayerManagerInitialize()
        {
        }

        [IteratorStateMachine(typeof(_003CWaitUntilEntityLoggedIn_003Ed__14))]
        private IEnumerator WaitUntilEntityLoggedIn(float secondsBetweenWait)
        {
            return null;
        }

        private void GetEntityTokenCompleted(GetEntityTokenResponse response)
        {
        }

        private void GetEntityTokenFailed(PlayFabError error)
        {
        }

        public void OnPlayFabPartyError(uint errorCode, PlayFabMultiplayerManagerErrorType type)
        {
        }

        public void DoWork()
        {
        }

        private void EventSentSuccessfulCallback(WriteEventsResponse response)
        {
        }

        private void EventSentErrorCallback(PlayFabError response)
        {
        }

        [CompilerGenerated]
        private sealed class _003CWaitUntilEntityLoggedIn_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;

            private object _003C_003E2__current;

            public PlayFabEventTracer _003C_003E4__this;

            private WaitForSeconds _003Cdelay_003E5__2;

            public float secondsBetweenWait;

            [DebuggerHidden]
            public _003CWaitUntilEntityLoggedIn_003Ed__14(int _003C_003E1__state)
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