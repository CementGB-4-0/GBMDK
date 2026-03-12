namespace PartyCSharpSDK
{
    public class PARTY_CHAT_CONTROL_HANDLE
    {
        internal PARTY_CHAT_CONTROL_HANDLE(Interop.PARTY_CHAT_CONTROL_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_CHAT_CONTROL_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_CHAT_CONTROL_HANDLE interopHandle,
            out PARTY_CHAT_CONTROL_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}