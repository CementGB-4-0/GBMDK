using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_DATA_BUFFER
    {
        internal readonly IntPtr buffer;

        internal readonly uint bufferByteCount;

        internal PARTY_DATA_BUFFER(byte[] publicObject, DisposableCollection disposableCollection)
        {
            buffer = (IntPtr)0;
            bufferByteCount = 0u;
        }

        internal PARTY_DATA_BUFFER(IntPtr bufferPtr, uint bufferSize)
        {
            buffer = (IntPtr)0;
            bufferByteCount = 0u;
        }
    }
}