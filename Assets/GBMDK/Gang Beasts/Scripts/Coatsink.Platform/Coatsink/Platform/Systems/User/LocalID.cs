using System;

namespace Coatsink.Platform.Systems.User
{
    [Serializable]
    public struct LocalID
    {
        public static readonly LocalID INVALID_ID;

        private int value;

        private LocalID(int value)
        {
            this.value = 0;
        }

        public static implicit operator LocalID(int value)
        {
            return default(LocalID);
        }

        public static implicit operator int(LocalID record)
        {
            return 0;
        }

        public bool IsValid()
        {
            return false;
        }

        public override string ToString()
        {
            return null;
        }
    }
}