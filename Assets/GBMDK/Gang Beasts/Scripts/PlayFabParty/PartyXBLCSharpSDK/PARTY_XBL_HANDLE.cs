namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_HANDLE
    {
        public PARTY_XBL_HANDLE(long handleValue)
        {
        }

        internal PARTY_XBL_HANDLE(Interop.PARTY_XBL_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_XBL_HANDLE InteropHandle { get; set; }

        public long GetHandleValue()
        {
            return 0L;
        }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_XBL_HANDLE interopHandle,
            out PARTY_XBL_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}