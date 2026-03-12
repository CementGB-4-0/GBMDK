namespace PartyCSharpSDK
{
    public class PARTY_TRANSLATION
    {
        internal PARTY_TRANSLATION(Interop.PARTY_TRANSLATION interopStruct)
        {
        }

        public PARTY_STATE_CHANGE_RESULT result { get; }

        public uint errorDetail { get; }

        public string languageCode { get; }

        public PARTY_TRANSLATION_RECEIVED_OPTIONS options { get; }

        public string translation { get; }
    }
}