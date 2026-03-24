using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CS.CorePlatform.Utils
{
    public class ThreadHandler
    {
        private int _numberCalling;

        private ThreadPriority _priority;

        private Thread _thread;

        private bool _threadAbort;

        private object _threadAbortLock;

        private object _threadCallLock;

        private List<Action> _threadCalls;

        private bool _threadComplete;

        private object _threadLock;
        private string _threadName;

        private bool _threadOnce;

        private object _threadOnceLock;

        private bool _threadPause;

        private bool _threadPaused;

        private object _threadPausedLock;

        private object _threadPauseLock;

        private bool _threadRestart;

        private object _threadRestartLock;

        private bool _threadWait;

        public bool ReuseThread;

        public int SleepTimeMS;

        public ThreadHandler(string name)
        {
        }

        public bool Running => false;

        public bool PauseThread
        {
            get { return false; }
            set { }
        }

        public bool ThreadPaused => false;

        private bool AbortThread
        {
            get { return false; }
            set { }
        }

        public bool RunThreadOnce
        {
            get { return false; }
            set { }
        }

        public ThreadPriority Priority
        {
            get { return default(ThreadPriority); }
            set { }
        }

        public event Action OnCompletion
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        ~ThreadHandler()
        {
        }

        public void Start()
        {
        }

        public void Abort(bool block)
        {
        }

        public void Pause(bool block)
        {
        }

        public void ForceAbort()
        {
        }

        public void Complete()
        {
        }

        public void AddPart(Action part)
        {
        }

        public void RemovePart(Action part)
        {
        }

        public void ClearParts()
        {
        }

        public bool HasPart(Action part)
        {
            return false;
        }

        public void Restart()
        {
        }

        public void ClearComplete()
        {
        }

        private void ClearThread()
        {
        }

        private void ThreadLoop()
        {
        }
    }
}