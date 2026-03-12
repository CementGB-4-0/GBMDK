using System;

namespace PartyCSharpSDK
{
    public class PARTY_MUTABLE_DATA_BUFFER
    {
        internal PARTY_MUTABLE_DATA_BUFFER(Interop.PARTY_MUTABLE_DATA_BUFFER interopStruct)
        {
        }

        public IntPtr Buffer { get; }

        public uint BufferByteCount { get; }
    }
}