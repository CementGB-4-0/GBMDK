using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_CHAT_TEXT_RECEIVED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_CHAT_CONTROL_HANDLE senderChatControl;

        internal readonly uint receiverChatControlCount;

        internal readonly IntPtr receiverChatControls;

        internal readonly IntPtr languageCode;

        internal readonly IntPtr chatText;

        internal readonly uint dataSize;

        internal readonly IntPtr data;

        internal readonly uint translationCount;

        internal readonly IntPtr translations;

        internal readonly PARTY_CHAT_TEXT_RECEIVED_OPTIONS options;

        internal readonly IntPtr originalChatText;

        internal readonly uint errorDetail;
    }
}