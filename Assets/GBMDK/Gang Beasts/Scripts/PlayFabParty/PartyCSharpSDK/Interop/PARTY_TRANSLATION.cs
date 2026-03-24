using System;

namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_TRANSLATION
    {
        internal readonly PARTY_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;

        internal readonly IntPtr languageCode;

        internal readonly PARTY_TRANSLATION_RECEIVED_OPTIONS options;

        internal readonly IntPtr translation;
    }
}