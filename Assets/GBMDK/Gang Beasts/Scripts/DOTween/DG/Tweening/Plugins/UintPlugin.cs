using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
    public class UintPlugin : ABSTweenPlugin<uint, uint, NoOptions>
    {
        public override void Reset(TweenerCore<uint, uint, NoOptions> t)
        {
        }

        public override uint ConvertToStartValue(TweenerCore<uint, uint, NoOptions> t, uint value)
        {
            return 0u;
        }

        public override void SetRelativeEndValue(TweenerCore<uint, uint, NoOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<uint, uint, NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, uint changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<uint> getter,
            DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration,
            bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}