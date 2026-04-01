using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
    public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions>
    {
        public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t)
        {
        }

        public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value)
        {
            return default(Vector2);
        }

        public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter,
            DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration,
            bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}