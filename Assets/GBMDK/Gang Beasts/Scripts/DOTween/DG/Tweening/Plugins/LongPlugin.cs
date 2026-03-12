using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
    public class LongPlugin : ABSTweenPlugin<long, long, NoOptions>
    {
        public override void Reset(TweenerCore<long, long, NoOptions> t)
        {
        }

        public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value)
        {
            return 0L;
        }

        public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<long, long, NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter,
            DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration,
            bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}