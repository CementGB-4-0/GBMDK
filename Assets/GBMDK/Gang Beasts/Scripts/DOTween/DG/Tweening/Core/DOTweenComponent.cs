using System.Collections;
using UnityEngine;

namespace DG.Tweening.Core
{
    [AddComponentMenu(null)]
    public class DOTweenComponent : MonoBehaviour, IDOTweenInit
    {
        public int inspectorUpdater;

        private bool _duplicateToDestroy;

        private float _unscaledDeltaTime;

        private float _unscaledTime;

        private void Awake()
        {
        }

        private void Start()
        {
        }

        private void Update()
        {
        }

        private void FixedUpdate()
        {
        }

        private void LateUpdate()
        {
        }

        private void OnDestroy()
        {
        }

        private void OnApplicationQuit()
        {
        }

        private void OnDrawGizmos()
        {
        }

        private void OnLevelWasLoaded()
        {
        }

        public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
        {
            return null;
        }

        internal IEnumerator WaitForCompletion(Tween t)
        {
            return null;
        }

        internal IEnumerator WaitForRewind(Tween t)
        {
            return null;
        }

        internal IEnumerator WaitForKill(Tween t)
        {
            return null;
        }

        internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops)
        {
            return null;
        }

        internal IEnumerator WaitForPosition(Tween t, float position)
        {
            return null;
        }

        internal IEnumerator WaitForStart(Tween t)
        {
            return null;
        }

        internal static void Create()
        {
        }

        internal static void DestroyInstance()
        {
        }
    }
}