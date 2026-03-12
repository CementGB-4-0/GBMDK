namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_CHAT_USER_HANDLE
    {
        internal PARTY_XBL_CHAT_USER_HANDLE(Interop.PARTY_XBL_CHAT_USER_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_XBL_CHAT_USER_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_XBL_CHAT_USER_HANDLE interopHandle,
            out PARTY_XBL_CHAT_USER_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}