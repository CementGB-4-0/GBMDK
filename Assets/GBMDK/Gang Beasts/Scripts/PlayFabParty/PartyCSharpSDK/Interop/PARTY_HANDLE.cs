using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_HANDLE
    {
        internal readonly IntPtr handle;

        internal PARTY_HANDLE(long handleValue)
        {
            handle = (IntPtr)0;
        }
    }
}