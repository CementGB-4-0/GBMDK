using System;

namespace Coatsink.Platform.Utils
{
    public class ActionList
    {
        private object _actionLock;

        private string _listName;

        private Action _waitingActions;

        public ActionList(string name)
        {
        }

        public void Update()
        {
        }
    }
}