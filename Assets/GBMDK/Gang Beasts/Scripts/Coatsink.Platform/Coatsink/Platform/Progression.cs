using System;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.Progression;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform
{
    public static class Progression
    {
        [CompilerGenerated] private static Action<LocalID, string, int> OnStatisticChangedInt;

        [CompilerGenerated] private static Action<LocalID, string, float> OnStatisticChangedFloat;

        [CompilerGenerated] private static Action<LocalID, string, int> OnStatisticChangedMask;

        [CompilerGenerated] private static Action<LocalID, string, bool> OnAchievementChanged;

        private static object _managerLock;

        private static IProgressionManager _progManager;

        public static IProgressionManager ProgressionManager
        {
            set { }
        }

        public static bool IsAchievementUnlocked(LocalID localID, string achievementCode)
        {
            return false;
        }

        public static void SetAchievement(LocalID localID, string achievementCode, bool unlock)
        {
        }

        public static class TriggerEvents
        {
            public static void OnAchievementChanged(LocalID localID, string achievementCode, bool unlocked)
            {
            }
        }

        public static class InjectionEvents
        {
            [CompilerGenerated] private static Action<LocalID> OnProgressionReady;

            public static event Action<LocalID, string, int> OnStatisticChangedInt
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

            public static event Action<LocalID, string, float> OnStatisticChangedFloat
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

            public static event Action<LocalID, string, int> OnStatisticChangedMask
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

            public static event Action<LocalID, string, bool> OnAchievementChanged
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

            public static class TriggerEvent
            {
                public static void OnAchievementChanged(LocalID localID, string achievementCode, bool unlocked)
                {
                }

                public static void OnProgressionReady(LocalID localID)
                {
                }
            }
        }
    }
}