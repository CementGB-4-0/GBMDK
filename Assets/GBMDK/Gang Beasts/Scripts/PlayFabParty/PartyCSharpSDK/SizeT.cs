using System;

namespace PartyCSharpSDK
{
    public struct SizeT
    {
        private readonly UIntPtr value;

        public bool IsZero => false;

        public SizeT(int length)
        {
            value = (UIntPtr)0u;
        }

        public SizeT(uint length)
        {
            value = (UIntPtr)0u;
        }

        public uint ToUInt32()
        {
            return 0u;
        }

        public int ToInt32()
        {
            return 0;
        }
    }
}