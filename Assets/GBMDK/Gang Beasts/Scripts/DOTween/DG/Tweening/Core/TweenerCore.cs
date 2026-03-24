using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;

namespace DG.Tweening.Core
{
    public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : struct
    {
        public T2 changeValue;

        public T2 endValue;

        public DOGetter<T1> getter;

        public TPlugOptions plugOptions;

        public DOSetter<T1> setter;
        public T2 startValue;

        internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;

        internal TweenerCore()
        {
        }

        internal sealed override void Reset()
        {
        }

        internal override bool Validate()
        {
            return false;
        }

        internal override float UpdateDelay(float elapsed)
        {
            return 0f;
        }

        internal override bool Startup()
        {
            return false;
        }

        internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps,
            bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
        {
            return false;
        }
    }
}