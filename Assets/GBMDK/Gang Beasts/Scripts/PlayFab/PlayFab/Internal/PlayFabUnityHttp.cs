using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace PlayFab.Internal
{
    public class PlayFabUnityHttp : ITransportPlugin, IPlayFabPlugin
    {
        private readonly int _pendingWwwMessages;

        private bool _isInitialized;

        public bool IsInitialized => false;

        public void Initialize()
        {
        }

        public void Update()
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

        public int GetPendingMessages()
        {
            return 0;
        }

        [IteratorStateMachine(typeof(_003CSimpleCallCoroutine_003Ed__10))]
        private static IEnumerator SimpleCallCoroutine(string method, string fullUrl, byte[] payload,
            Action<byte[]> successCallback, Action<string> errorCallback)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CPost_003Ed__12))]
        private IEnumerator Post(CallRequestContainer reqContainer)
        {
            return null;
        }

        public void OnResponse(string response, CallRequestContainer reqContainer)
        {
        }

        public void OnError(string error, CallRequestContainer reqContainer)
        {
        }

        [CompilerGenerated]
        private sealed class _003CSimpleCallCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;

            private object _003C_003E2__current;

            private UnityWebRequest _003Cwww_003E5__2;

            public Action<string> errorCallback;

            public string fullUrl;

            public string method;

            public byte[] payload;

            public Action<byte[]> successCallback;

            [DebuggerHidden]
            public _003CSimpleCallCoroutine_003Ed__10(int _003C_003E1__state)
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

            private void _003C_003Em__Finally1()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003CPost_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;

            private object _003C_003E2__current;

            public PlayFabUnityHttp _003C_003E4__this;

            private UnityWebRequest _003Cwww_003E5__2;

            public CallRequestContainer reqContainer;

            [DebuggerHidden]
            public _003CPost_003Ed__12(int _003C_003E1__state)
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

            private void _003C_003Em__Finally1()
            {
            }
        }
    }
}