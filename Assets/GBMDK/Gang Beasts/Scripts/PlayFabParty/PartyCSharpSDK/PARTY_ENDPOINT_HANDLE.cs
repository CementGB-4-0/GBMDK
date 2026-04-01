namespace PartyCSharpSDK
{
    public class PARTY_ENDPOINT_HANDLE
    {
        internal PARTY_ENDPOINT_HANDLE(Interop.PARTY_ENDPOINT_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_ENDPOINT_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_ENDPOINT_HANDLE interopHandle,
            out PARTY_ENDPOINT_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}