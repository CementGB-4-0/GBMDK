using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
    public class PulseHelper : MonoBehaviour
    {
        private WaitForSecondsRealtime _pulser;

        private Coroutine _tracker;

        public Func<bool> PulseLogic;

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void StartHelper(int burstLimit, int sustainLimit)
        {
        }

        [IteratorStateMachine(typeof(_003CLogicKeeper_003Ed__6))]
        private IEnumerator LogicKeeper()
        {
            return null;
        }

        [CompilerGenerated]
        private sealed class _003CLogicKeeper_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;

            private object _003C_003E2__current;

            public PulseHelper _003C_003E4__this;

            private bool _003Cfree_003E5__2;

            [DebuggerHidden]
            public _003CLogicKeeper_003Ed__6(int _003C_003E1__state)
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