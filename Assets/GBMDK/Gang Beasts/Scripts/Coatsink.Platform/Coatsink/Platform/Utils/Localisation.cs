using System;
using System.Runtime.CompilerServices;

namespace Coatsink.Platform.Utils
{
    public static class Localisation
    {
        private static readonly object _locker;

        public static event Func<string, string, int, object[], string> TargetedLocaliseLogic
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Func<string, int, object[], string> LocaliseLogic
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static string Localise(string code, params object[] info)
        {
            return null;
        }

        private static string GetUnlocalisedContent(string code, object[] info)
        {
            return null;
        }
    }
}