using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
    public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions>
    {
        public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
        {
        }

        public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t,
            Vector3 value)
        {
            return null;
        }

        public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond,
            Vector3[] changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(Vector3ArrayOptions options, Tween t, bool isRelative,
            DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue,
            Vector3[] changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}