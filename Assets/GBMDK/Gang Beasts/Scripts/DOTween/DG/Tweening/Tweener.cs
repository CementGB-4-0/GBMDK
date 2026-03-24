using DG.Tweening.Core;
using DG.Tweening.Plugins.Core;

namespace DG.Tweening
{
    public abstract class Tweener : Tween
    {
        internal bool hasManuallySetStartValue;

        internal bool isFromAllowed;

        internal Tweener()
        {
        }

        internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter,
            DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
            where TPlugOptions : struct
        {
            return false;
        }

        internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed)
            where TPlugOptions : struct
        {
            return 0f;
        }

        internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
            where TPlugOptions : struct
        {
            return false;
        }

        private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
            where TPlugOptions : struct
        {
            return false;
        }

        private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
            where TPlugOptions : struct
        {
        }
    }
}