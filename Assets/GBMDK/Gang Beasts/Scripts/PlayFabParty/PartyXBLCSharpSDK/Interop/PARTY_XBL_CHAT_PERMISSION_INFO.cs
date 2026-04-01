using PartyCSharpSDK;

namespace PartyXBLCSharpSDK.Interop
{
    internal struct PARTY_XBL_CHAT_PERMISSION_INFO
    {
        internal readonly PARTY_CHAT_PERMISSION_OPTIONS chatPermissionMask;

        internal readonly PARTY_XBL_CHAT_PERMISSION_MASK_REASON reason;

        internal PARTY_XBL_CHAT_PERMISSION_INFO(PartyXBLCSharpSDK.PARTY_XBL_CHAT_PERMISSION_INFO publicObject)
        {
            chatPermissionMask = default(PARTY_CHAT_PERMISSION_OPTIONS);
            reason = default(PARTY_XBL_CHAT_PERMISSION_MASK_REASON);
        }
    }
}