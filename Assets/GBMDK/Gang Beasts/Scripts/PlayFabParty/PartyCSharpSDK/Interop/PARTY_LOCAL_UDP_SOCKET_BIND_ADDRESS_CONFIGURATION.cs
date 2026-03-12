namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_CONFIGURATION
    {
        internal readonly PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_OPTIONS options;

        internal readonly ushort port;

        internal PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_CONFIGURATION(
            PartyCSharpSDK.PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_CONFIGURATION publicObject)
        {
            options = default(PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_OPTIONS);
            port = 0;
        }
    }
}