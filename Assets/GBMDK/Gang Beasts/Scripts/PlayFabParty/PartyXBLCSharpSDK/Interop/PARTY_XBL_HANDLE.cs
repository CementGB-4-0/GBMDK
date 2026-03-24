using System;

namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_HANDLE
    {
        internal readonly IntPtr handle;

        internal PARTY_XBL_HANDLE(long handleValue)
        {
            handle = (IntPtr)0;
        }
    }
}