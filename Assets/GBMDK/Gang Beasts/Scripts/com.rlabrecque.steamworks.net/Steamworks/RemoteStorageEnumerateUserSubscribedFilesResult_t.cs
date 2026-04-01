using System.Runtime.InteropServices;

namespace Steamworks
{
    [StructLayout((LayoutKind)0, Pack = 8, Size = 616)]
    [CallbackIdentity(1314)]
    public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
    {
        public EResult m_eResult;

        public int m_nResultsReturned;

        public int m_nTotalResultCount;

        public PublishedFileId_t[] m_rgPublishedFileId;

        public uint[] m_rgRTimeSubscribed;
    }
}