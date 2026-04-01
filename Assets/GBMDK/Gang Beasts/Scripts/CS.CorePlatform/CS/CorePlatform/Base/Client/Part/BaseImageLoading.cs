using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CS.CorePlatform.Base.Client.Part
{
    public abstract class BaseImageLoading : MonoBehaviour
    {
        protected Dictionary<Texture2D, BaseUserInfo> _LoadingImages;

        protected Dictionary<BaseUserInfo, Texture2D> _StoredPictures;

        protected Dictionary<BaseUserInfo, Texture2D> _WaitingLoadedPictures;

        public bool TryLoadingFromStored(BaseUserInfo id, ref Texture2D textureStore)
        {
            return false;
        }

        public void UnloadPlayingWithImage(BaseUserInfo id)
        {
        }

        public void StartLoadingImage(ref Texture2D textureStore, string imageURL)
        {
        }

        [IteratorStateMachine(typeof(_003CWaitForFullyLoaded_003Ed__6))]
        protected IEnumerator WaitForFullyLoaded(WWW imageLoading, Texture2D storepoint)
        {
            return null;
        }

        [CompilerGenerated]
        private sealed class _003CWaitForFullyLoaded_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;

            private object _003C_003E2__current;

            public BaseImageLoading _003C_003E4__this;

            public WWW imageLoading;

            public Texture2D storepoint;

            [DebuggerHidden]
            public _003CWaitForFullyLoaded_003Ed__6(int _003C_003E1__state)
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