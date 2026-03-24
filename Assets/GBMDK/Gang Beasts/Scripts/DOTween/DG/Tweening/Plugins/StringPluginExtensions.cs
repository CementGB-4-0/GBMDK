using System.Text;

namespace DG.Tweening.Plugins
{
    internal static class StringPluginExtensions
    {
        public static readonly char[] ScrambledCharsAll;

        public static readonly char[] ScrambledCharsUppercase;

        public static readonly char[] ScrambledCharsLowercase;

        public static readonly char[] ScrambledCharsNumerals;

        private static int _lastRndSeed;

        static StringPluginExtensions()
        {
        }

        internal static void ScrambleChars(this char[] chars)
        {
        }

        internal static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, char[] chars)
        {
            return null;
        }
    }
}