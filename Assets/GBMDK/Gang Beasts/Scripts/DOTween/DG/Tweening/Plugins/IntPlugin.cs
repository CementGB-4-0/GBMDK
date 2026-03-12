using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
    public class IntPlugin : ABSTweenPlugin<int, int, NoOptions>
    {
        public override void Reset(TweenerCore<int, int, NoOptions> t)
        {
        }

        public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value)
        {
            return 0;
        }

        public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<int, int, NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter,
            DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration,
            bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}