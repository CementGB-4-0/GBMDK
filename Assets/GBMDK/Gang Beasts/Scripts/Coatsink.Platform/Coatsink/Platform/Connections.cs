using System;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.Online;

namespace Coatsink.Platform
{
    public class Connections
    {
        private static readonly object _managerLock;

        private static IOnlineConnectionManager _onlineConnectionManager;

        public static IOnlineConnectionManager OnlineConnectionManager => null;

        public static event Action<bool> OnConnectionChange
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static uint HasOnlineConnection()
        {
            return 0u;
        }
    }
}