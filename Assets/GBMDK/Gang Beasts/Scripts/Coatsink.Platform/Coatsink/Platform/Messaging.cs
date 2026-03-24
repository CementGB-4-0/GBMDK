using System.Collections.Generic;
using System.IO;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Utils;

namespace Coatsink.Platform
{
    public static class Messaging
    {
        private static readonly object _threadLock;

        private static readonly object _managerLock;

        private static readonly object _boxLock;

        private static readonly List<IMessagingManager> _messageSystems;

        private static readonly object _writerLock;

        private static readonly MemoryStream _messageStream;

        private static readonly BinaryWriter _messageWriter;

        private static ThreadHandler _messageThread;

        public static void AbortThread(bool block)
        {
        }
    }
}