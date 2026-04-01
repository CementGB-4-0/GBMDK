using System.Collections.Generic;
using DG.Tweening.Core.Enums;

namespace DG.Tweening.Core
{
    internal static class TweenManager
    {
        internal static int maxActive;

        internal static int maxTweeners;

        internal static int maxSequences;

        internal static bool hasActiveTweens;

        internal static bool hasActiveDefaultTweens;

        internal static bool hasActiveLateTweens;

        internal static bool hasActiveFixedTweens;

        internal static int totActiveTweens;

        internal static int totActiveDefaultTweens;

        internal static int totActiveLateTweens;

        internal static int totActiveFixedTweens;

        internal static int totActiveTweeners;

        internal static int totActiveSequences;

        internal static int totPooledTweeners;

        internal static int totPooledSequences;

        internal static int totTweeners;

        internal static int totSequences;

        internal static bool isUpdateLoop;

        private static Tween[] _activeTweens;

        private static Tween[] _pooledTweeners;

        private static readonly Stack<Tween> _PooledSequences;

        private static readonly List<Tween> _KillList;

        private static int _maxActiveLookupId;

        private static bool _requiresActiveReorganization;

        private static int _reorganizeFromId;

        private static int _minPooledTweenerId;

        private static int _maxPooledTweenerId;

        internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : struct
        {
            return null;
        }

        internal static Sequence GetSequence()
        {
            return null;
        }

        internal static void AddActiveTweenToSequence(Tween t)
        {
        }

        internal static void Despawn(Tween t, bool modifyActiveLists = true)
        {
        }

        internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
        {
        }

        internal static int Validate()
        {
            return 0;
        }

        internal static void Update(UpdateType updateType, float deltaTime, float independentTime)
        {
        }

        internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
        {
            return false;
        }

        internal static bool Pause(Tween t)
        {
            return false;
        }

        internal static bool Play(Tween t)
        {
            return false;
        }

        private static void MarkForKilling(Tween t)
        {
        }

        private static void AddActiveTween(Tween t)
        {
        }

        private static void ReorganizeActiveTweens()
        {
        }

        private static void DespawnTweens(List<Tween> tweens, bool modifyActiveLists = true)
        {
        }

        private static void RemoveActiveTween(Tween t)
        {
        }

        private static void IncreaseCapacities(CapacityIncreaseMode increaseMode)
        {
        }

        internal enum CapacityIncreaseMode
        {
            TweenersAndSequences = 0,
            TweenersOnly = 1,
            SequencesOnly = 2
        }
    }
}