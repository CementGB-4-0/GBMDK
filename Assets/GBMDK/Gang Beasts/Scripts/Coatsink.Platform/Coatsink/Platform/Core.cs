using System;
using System.Collections.Generic;
using System.Threading;
using Coatsink.Platform.Systems;
using Coatsink.Platform.Utils;
using PlatformID = Coatsink.Platform.Systems.PlatformID;

namespace Coatsink.Platform
{
    public static class Core
    {
        private static readonly ActionQueue _mainThreadActions;

        private static readonly ActionQueue _offThreadActions;

        private static readonly ActionList _mainUpdateActions;

        private static readonly object _managerLocker;

        private static readonly List<IPlatformCore> _cores;

        private static readonly List<IAddon> _addons;

        private static ThreadHandler _platformThread;

        private static IPlatformCore _activeMainCore;

        public static IPlatformCore MainCore
        {
            set { }
        }

        public static PlatformID PlatformID => default(PlatformID);

        public static void AddMainThreadAction(Action action)
        {
        }

        public static void AddOffThreadAction(Action action)
        {
        }

        public static void AddOffThreadUpdate(Action action)
        {
        }

        public static void RemoveOffThreadUpdate(Action action)
        {
        }

        public static int AddAddon(IAddon addon)
        {
            return 0;
        }

        public static TaskResult<bool> Initialize(IPlatformCore core, TaskResult<bool> taskResult = null,
            ThreadPriority threadPriority = ThreadPriority.BelowNormal)
        {
            return null;
        }

        public static void Update()
        {
        }

        public static int Terminate(IPlatformCore core)
        {
            return 0;
        }

        private static void UpdateCores()
        {
        }
    }
}