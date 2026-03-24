using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
    public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
    {
        private static RectOffset _r;

        public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t)
        {
        }

        public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t,
            RectOffset value)
        {
            return null;
        }

        public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter,
            DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration,
            bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}