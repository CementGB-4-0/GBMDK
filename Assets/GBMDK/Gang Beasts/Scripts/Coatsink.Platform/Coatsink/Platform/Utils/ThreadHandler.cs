using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Coatsink.Platform.Utils
{
    public class ThreadHandler
    {
        public static Action<ThreadHandler> SystemThreadSetup;

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

        [CompilerGenerated] private Action OnCompletionMain;

        [CompilerGenerated] private Action OnCompletionOff;

        public ThreadHandler(string name)
        {
        }

        public bool Running => false;

        public bool PauseThread
        {
            get { return false; }
            set { }
        }

        private bool AbortThread
        {
            get { return false; }
            set { }
        }

        public bool RunThreadOnce => false;

        public ThreadPriority Priority
        {
            set { }
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

        private void Complete()
        {
        }

        public void AddPart(Action part)
        {
        }

        public void RemovePart(Action part)
        {
        }

        public void Restart()
        {
        }

        private void ThreadLoop()
        {
        }
    }
}