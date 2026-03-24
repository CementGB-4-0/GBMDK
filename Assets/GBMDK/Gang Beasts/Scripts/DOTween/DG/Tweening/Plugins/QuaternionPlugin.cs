using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
    public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>
    {
        public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
        {
        }

        public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t,
            Quaternion value)
        {
            return default(Vector3);
        }

        public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative,
            DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue,
            Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }
    }
}