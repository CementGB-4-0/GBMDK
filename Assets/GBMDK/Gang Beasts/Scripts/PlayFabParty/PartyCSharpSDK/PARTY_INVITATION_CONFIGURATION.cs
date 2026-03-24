namespace PartyCSharpSDK
{
    public class PARTY_INVITATION_CONFIGURATION
    {
        internal PARTY_INVITATION_CONFIGURATION(Interop.PARTY_INVITATION_CONFIGURATION interopStruct)
        {
        }

        public PARTY_INVITATION_CONFIGURATION()
        {
        }

        public string Identifier { get; set; }

        public PARTY_INVITATION_REVOCABILITY Revocability { get; set; }

        public string[] EntityIds { get; set; }
    }
}