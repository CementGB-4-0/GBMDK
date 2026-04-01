namespace DG.Tweening
{
    public static class TweenSettingsExtensions
    {
        public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion) where T : Tween
        {
            return null;
        }

        public static T SetTarget<T>(this T t, object target) where T : Tween
        {
            return null;
        }

        public static T SetEase<T>(this T t, Ease ease) where T : Tween
        {
            return null;
        }

        public static Sequence Append(this Sequence s, Tween t)
        {
            return null;
        }
    }
}