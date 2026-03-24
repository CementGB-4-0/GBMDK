using UnityEngine;

namespace DG.Tweening
{
    public struct Color2
    {
        public Color ca;

        public Color cb;

        public Color2(Color ca, Color cb)
        {
            this.ca = default(Color);
            this.cb = default(Color);
        }

        public static Color2 operator +(Color2 c1, Color2 c2)
        {
            return default(Color2);
        }

        public static Color2 operator -(Color2 c1, Color2 c2)
        {
            return default(Color2);
        }

        public static Color2 operator *(Color2 c1, float f)
        {
            return default(Color2);
        }
    }
}