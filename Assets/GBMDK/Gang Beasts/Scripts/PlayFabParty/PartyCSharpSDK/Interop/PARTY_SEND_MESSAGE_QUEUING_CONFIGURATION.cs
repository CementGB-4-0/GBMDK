namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION
    {
        internal readonly sbyte priority;

        internal readonly uint identityForCancelFilters;

        internal readonly uint timeoutInMilliseconds;

        internal PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION(
            PartyCSharpSDK.PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION publicObject)
        {
            priority = 0;
            identityForCancelFilters = 0u;
            timeoutInMilliseconds = 0u;
        }
    }
}