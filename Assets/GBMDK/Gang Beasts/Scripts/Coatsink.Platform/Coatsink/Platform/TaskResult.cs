using System;
using System.Threading.Tasks;

namespace Coatsink.Platform
{
    public class TaskResult : TaskResultBase<TaskResult>
    {
        private Action<TaskResult> _continuation;

        private TaskResult _continuationTask;
        private TaskCompletionSource<int> _tcs;
    }

    public class TaskResult<T1> : TaskResultBase<TaskResult<T1>>
    {
        private Action<TaskResult<T1>> _continuation;

        private TaskResult _continuationTask;

        protected T1 _result;
        private TaskCompletionSource<T1> _tcs;

        public T1 Result
        {
            get { return default(T1); }
            set { }
        }

        protected override void ResetInternal()
        {
        }

        protected override void CompleteInternal()
        {
        }
    }

    public class TaskResult<T1, T2> : TaskResultBase<TaskResult<T1, T2>>
    {
        private Action<TaskResult<T1, T2>> _continuation;

        protected T1 _result1;

        protected T2 _result2;

        private TaskCompletionSource<Result> _tcs;

        public T1 Result1
        {
            get { return default(T1); }
            set { }
        }

        public T2 Result2
        {
            get { return default(T2); }
            set { }
        }

        protected override void ResetInternal()
        {
        }

        protected override void CompleteInternal()
        {
        }

        public readonly struct Result
        {
            public readonly T1 Result1;

            public readonly T2 Result2;

            public Result(T1 a, T2 b)
            {
                Result1 = default(T1);
                Result2 = default(T2);
            }
        }
    }
}