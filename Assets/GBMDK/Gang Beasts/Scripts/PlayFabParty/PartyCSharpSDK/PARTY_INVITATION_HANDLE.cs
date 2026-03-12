namespace PartyCSharpSDK
{
    public class PARTY_INVITATION_HANDLE
    {
        internal PARTY_INVITATION_HANDLE(Interop.PARTY_INVITATION_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_INVITATION_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_INVITATION_HANDLE interopHandle,
            out PARTY_INVITATION_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}