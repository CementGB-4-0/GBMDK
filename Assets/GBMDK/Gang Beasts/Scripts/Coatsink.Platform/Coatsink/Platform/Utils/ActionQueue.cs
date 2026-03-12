using System;

namespace Coatsink.Platform.Utils
{
    public class ActionQueue
    {
        private object _actionLock;

        private string _queueName;

        private Action _waitingActions;

        public ActionQueue(string name)
        {
        }

        public void Update()
        {
        }

        public void AddAction(Action action)
        {
        }
    }
}