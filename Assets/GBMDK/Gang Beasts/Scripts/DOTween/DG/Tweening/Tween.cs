using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

namespace DG.Tweening
{
    public abstract class Tween : ABSSequentiable
    {
        internal bool active;

        internal int activeId;

        internal bool autoKill;

        internal int completedLoops;

        internal bool creationLocked;

        internal EaseFunction customEase;

        internal float delay;

        internal bool delayComplete;

        internal float duration;

        public float easeOvershootOrAmplitude;

        public float easePeriod;

        internal Ease easeType;

        internal float elapsedDelay;

        internal float fullDuration;

        public object id;

        public bool isBackwards;

        internal bool isBlendable;

        internal bool isComplete;

        internal bool isFrom;

        internal bool isIndependentUpdate;

        internal bool isPlaying;

        internal bool isRecyclable;

        internal bool isRelative;

        internal bool isSequenced;

        internal bool isSpeedBased;

        internal int loops;

        internal LoopType loopType;

        internal int miscInt;

        internal TweenCallback onComplete;

        internal TweenCallback onKill;

        internal TweenCallback onPause;

        internal TweenCallback onPlay;

        internal TweenCallback onRewind;

        internal TweenCallback onStepComplete;

        internal TweenCallback onUpdate;

        internal TweenCallback<int> onWaypointChange;

        internal bool playedOnce;

        internal float position;

        internal Sequence sequenceParent;

        internal SpecialStartupMode specialStartupMode;

        internal bool startupDone;

        public object target;
        public float timeScale;

        internal Type typeofT1;

        internal Type typeofT2;

        internal Type typeofTPlugOptions;

        internal UpdateType updateType;

        internal virtual void Reset()
        {
        }

        internal abstract bool Validate();

        internal virtual float UpdateDelay(float elapsed)
        {
            return 0f;
        }

        internal abstract bool Startup();

        internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps,
            bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);

        internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
        {
            return false;
        }

        internal static bool OnTweenCallback(TweenCallback callback)
        {
            return false;
        }
    }
}