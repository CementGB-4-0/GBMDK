using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Coatsink.Platform
{
    public class TaskResultBase<T> : IEnumerator, ITaskResult where T : TaskResultBase<T>
    {
        protected object _lock;

        protected uint _platformResult;

        protected TaskState _state;

        protected uint _systemResult;

        public bool CompleteOffThread;

        public bool IsComplete => false;

        public bool IsSuccessful => false;

        public bool IsFail => false;

        public bool IsActive => false;

        public uint SystemResult => 0u;

        public object Current => null;

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }

        public bool IsFinalised => false;

        public event Action<T> OnComplete
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public void Reset(bool deepReset = true)
        {
        }

        protected virtual void Clear(bool deepReset)
        {
        }

        private void CompleteAction(T self)
        {
        }

        protected virtual void CompleteInternal()
        {
        }

        protected virtual void ResetInternal()
        {
        }

        internal void Activate()
        {
        }

        public void Fail(uint fail = uint.MaxValue)
        {
        }

        public void Complete(uint pass = 0u)
        {
        }
    }
}