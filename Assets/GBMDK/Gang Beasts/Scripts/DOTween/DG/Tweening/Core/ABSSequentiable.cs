namespace DG.Tweening.Core
{
    public abstract class ABSSequentiable
    {
        internal TweenCallback onStart;

        internal float sequencedEndPosition;

        internal float sequencedPosition;
        internal TweenType tweenType;
    }
}