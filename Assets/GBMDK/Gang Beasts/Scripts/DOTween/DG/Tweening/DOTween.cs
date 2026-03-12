using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
    public class DOTween
    {
        public static readonly string Version;

        public static bool useSafeMode;

        public static bool showUnityEditorReport;

        public static float timeScale;

        public static bool useSmoothDeltaTime;

        private static LogBehaviour _logBehaviour;

        public static bool drawGizmos;

        public static UpdateType defaultUpdateType;

        public static bool defaultTimeScaleIndependent;

        public static AutoPlay defaultAutoPlay;

        public static bool defaultAutoKill;

        public static LoopType defaultLoopType;

        public static bool defaultRecyclable;

        public static Ease defaultEaseType;

        public static float defaultEaseOvershootOrAmplitude;

        public static float defaultEasePeriod;

        internal static DOTweenComponent instance;

        internal static bool isUnityEditor;

        internal static int maxActiveTweenersReached;

        internal static int maxActiveSequencesReached;

        internal static readonly List<TweenCallback> GizmosDelegates;

        internal static bool initialized;

        internal static bool isQuitting;

        static DOTween()
        {
        }

        public static LogBehaviour logBehaviour
        {
            get { return default(LogBehaviour); }
            set { }
        }

        private static void AutoInit()
        {
        }

        private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode,
            LogBehaviour? logBehaviour)
        {
            return null;
        }

        public static int Validate()
        {
            return 0;
        }

        public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter,
            Color endValue, float duration)
        {
            return null;
        }

        public static Sequence Sequence()
        {
            return null;
        }

        private static void InitCheck()
        {
        }

        private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter,
            DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
            where TPlugOptions : struct
        {
            return null;
        }
    }
}