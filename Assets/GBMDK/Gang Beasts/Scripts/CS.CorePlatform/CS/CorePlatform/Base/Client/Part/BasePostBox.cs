using CS.CorePlatform.Utils;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Base.Client.Part
{
    public abstract class BasePostBox<T> : MonoBehaviour where T : struct
    {
        private static object _lockSend;

        private static object _lockThread;

        protected ThreadHandler _messageThread;
        protected byte[] _newMessage;

        private PlatformMessageBase _pongMessage;

        private T _senderID;

        private bool RunThread => false;

        public void SendMessage(T userID, PlatformMessageBase message, bool reliable)
        {
        }

        public abstract void SendNewMessage(T userID, byte[] message, int size, bool reliable);

        public void StartMessageThread()
        {
        }

        public void StopMessageThread()
        {
        }

        public void WaitForMessageThreadEnd()
        {
        }

        public void SortMessages()
        {
        }

        protected abstract bool GetMessage(ref T senderID, out DataReader message);

        protected virtual void ParseMessage(T senderID, DataReader message)
        {
        }
    }
}