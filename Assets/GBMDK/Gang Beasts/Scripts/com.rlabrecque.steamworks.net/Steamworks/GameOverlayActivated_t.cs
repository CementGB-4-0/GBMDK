using System.Runtime.InteropServices;

namespace Steamworks
{
    [StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
    [CallbackIdentity(331)]
    public struct GameOverlayActivated_t
    {
        public byte m_bActive;

        public bool m_bUserInitiated;

        public AppId_t m_nAppID;
    }
}