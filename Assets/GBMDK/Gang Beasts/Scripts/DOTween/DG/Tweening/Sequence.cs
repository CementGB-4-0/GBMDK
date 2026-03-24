using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

namespace DG.Tweening
{
    public sealed class Sequence : Tween
    {
        private readonly List<ABSSequentiable> _sequencedObjs;
        internal readonly List<Tween> sequencedTweens;

        internal float lastTweenInsertTime;

        internal Sequence()
        {
        }

        internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
        {
            return null;
        }

        internal override void Reset()
        {
        }

        internal override bool Validate()
        {
            return false;
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

        internal static void Setup(Sequence s)
        {
        }

        internal static bool DoStartup(Sequence s)
        {
            return false;
        }

        internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps,
            bool useInversePosition, UpdateMode updateMode)
        {
            return false;
        }

        private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode,
            bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
        {
            return false;
        }

        private static int SortSequencedObjs(ABSSequentiable a, ABSSequentiable b)
        {
            return 0;
        }
    }
}