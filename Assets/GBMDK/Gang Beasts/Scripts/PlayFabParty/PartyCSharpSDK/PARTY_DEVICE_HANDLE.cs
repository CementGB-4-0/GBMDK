namespace PartyCSharpSDK
{
    public class PARTY_DEVICE_HANDLE
    {
        internal PARTY_DEVICE_HANDLE(Interop.PARTY_DEVICE_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_DEVICE_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_DEVICE_HANDLE interopHandle,
            out PARTY_DEVICE_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}