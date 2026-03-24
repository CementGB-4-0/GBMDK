using System.Runtime.InteropServices;

namespace Steamworks
{
    [StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
    [CallbackIdentity(703)]
    public struct SteamAPICallCompleted_t
    {
        public SteamAPICall_t m_hAsyncCall;

        public int m_iCallback;

        public uint m_cubParam;
    }
}