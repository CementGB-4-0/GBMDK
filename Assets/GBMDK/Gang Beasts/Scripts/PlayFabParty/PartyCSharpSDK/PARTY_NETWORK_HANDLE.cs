namespace PartyCSharpSDK
{
    public class PARTY_NETWORK_HANDLE
    {
        internal PARTY_NETWORK_HANDLE(Interop.PARTY_NETWORK_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_NETWORK_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_NETWORK_HANDLE interopHandle,
            out PARTY_NETWORK_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}