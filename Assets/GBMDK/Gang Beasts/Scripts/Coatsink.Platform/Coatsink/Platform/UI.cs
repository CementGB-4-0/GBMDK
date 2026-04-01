using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.UI;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform
{
    public static class UI
    {
        private static bool _lastOverlay;

        private static bool _nextOverlay;

        private static bool _queuedOverlayChange;

        private static object _lockerManager;

        private static IUIPopUpManager _uiPopUpManager;

        private static IUIPlatformManager _overlayManager;

        private static IDisplayTask _currentTask;

        private static Queue<IDisplayTask> _jobs;

        public static IUIPopUpManager PopUpUI
        {
            set { }
        }

        public static IUIPlatformManager PlatformUI
        {
            set { }
        }

        public static bool MessageActive => false;

        public static bool SystemActive => false;

        public static event Action<bool> OnPopupChanged
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<bool> OnOverlayChanged
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static uint ShowYESNO(IDisplayTask taskResult)
        {
            return 0u;
        }

        public static DisplayTask ShowYESNO(string body, DisplayTask task = null)
        {
            return null;
        }

        public static uint OpenUserProfile(LocalID localID, UserInfo onlineUser)
        {
            return 0u;
        }

        private static void Update()
        {
        }

        private static void EnqueueJob(IDisplayTask task)
        {
        }

        public static class TriggerEvents
        {
            internal static void TriggerOnPopupOpened()
            {
            }

            internal static void TriggerOnPopupClosed()
            {
            }

            public static void TriggerOnOverlayChanged()
            {
            }

            private static void DoOnOverlayChanged()
            {
            }
        }
    }
}