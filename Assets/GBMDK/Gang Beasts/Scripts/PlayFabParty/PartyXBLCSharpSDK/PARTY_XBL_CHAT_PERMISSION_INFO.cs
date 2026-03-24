using PartyCSharpSDK;

namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_CHAT_PERMISSION_INFO
    {
        internal PARTY_XBL_CHAT_PERMISSION_INFO(Interop.PARTY_XBL_CHAT_PERMISSION_INFO interopStruct)
        {
        }

        public PARTY_CHAT_PERMISSION_OPTIONS ChatPermissionMask { get; }

        public PARTY_XBL_CHAT_PERMISSION_MASK_REASON Reason { get; }
    }
}