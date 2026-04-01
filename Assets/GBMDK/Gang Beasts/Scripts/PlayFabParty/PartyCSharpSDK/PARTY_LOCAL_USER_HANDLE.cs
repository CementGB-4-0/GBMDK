namespace PartyCSharpSDK
{
    public class PARTY_LOCAL_USER_HANDLE
    {
        internal PARTY_LOCAL_USER_HANDLE(Interop.PARTY_LOCAL_USER_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_LOCAL_USER_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_LOCAL_USER_HANDLE interopHandle,
            out PARTY_LOCAL_USER_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}