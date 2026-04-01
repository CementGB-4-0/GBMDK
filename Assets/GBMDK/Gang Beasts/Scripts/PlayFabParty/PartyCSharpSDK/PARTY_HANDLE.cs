namespace PartyCSharpSDK
{
    public class PARTY_HANDLE
    {
        public PARTY_HANDLE(long handleValue)
        {
        }

        internal PARTY_HANDLE(Interop.PARTY_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_HANDLE InteropHandle { get; set; }

        public long GetHandleValue()
        {
            return 0L;
        }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_HANDLE interopHandle, out PARTY_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}