using UnityEngine;

namespace DG.Tweening.Core
{
    public class DOTweenSettings : ScriptableObject
    {
        public enum SettingsLocation
        {
            AssetsDirectory = 0,
            DOTweenDirectory = 1,
            DemigiantDirectory = 2
        }

        public const string AssetName = "DOTweenSettings";

        public bool useSafeMode;

        public float timeScale;

        public bool useSmoothDeltaTime;

        public bool showUnityEditorReport;

        public LogBehaviour logBehaviour;

        public bool drawGizmos;

        public bool defaultRecyclable;

        public AutoPlay defaultAutoPlay;

        public UpdateType defaultUpdateType;

        public bool defaultTimeScaleIndependent;

        public Ease defaultEaseType;

        public float defaultEaseOvershootOrAmplitude;

        public float defaultEasePeriod;

        public bool defaultAutoKill;

        public LoopType defaultLoopType;

        public SettingsLocation storeSettingsLocation;
    }
}