namespace PartyCSharpSDK
{
    public class PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION
    {
        internal PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION(
            Interop.PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION interopStruct)
        {
        }

        public PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION()
        {
        }

        public sbyte Priority { get; set; }

        public uint IdentityForCancelFilters { get; set; }

        public uint TimeoutInMilliseconds { get; set; }
    }
}