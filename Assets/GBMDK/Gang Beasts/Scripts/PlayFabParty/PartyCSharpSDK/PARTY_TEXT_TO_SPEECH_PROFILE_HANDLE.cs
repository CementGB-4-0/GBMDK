namespace PartyCSharpSDK
{
    public class PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE
    {
        internal PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE(Interop.PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE interopHandle)
        {
        }

        internal Interop.PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE InteropHandle { get; set; }

        internal static uint WrapAndReturnError(uint error, Interop.PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE interopHandle,
            out PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        internal void ClearInteropHandle()
        {
        }
    }
}