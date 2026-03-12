using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
    public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions>
    {
        public override void Reset(TweenerCore<Color, Color, ColorOptions> t)
        {
        }

        public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value)
        {
            return default(Color);
        }

        public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter,
            DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration,
            bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}