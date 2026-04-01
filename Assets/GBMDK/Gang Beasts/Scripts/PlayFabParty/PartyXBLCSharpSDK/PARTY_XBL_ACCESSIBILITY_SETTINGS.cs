using PartyCSharpSDK;

namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_ACCESSIBILITY_SETTINGS
    {
        internal PARTY_XBL_ACCESSIBILITY_SETTINGS(Interop.PARTY_XBL_ACCESSIBILITY_SETTINGS interopStruct)
        {
        }

        public byte SpeechToTextEnabled { get; }

        public byte TextToSpeechEnabled { get; }

        public string LanguageCode { get; }

        public PARTY_GENDER Gender { get; }
    }
}