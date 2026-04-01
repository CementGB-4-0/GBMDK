namespace PartyCSharpSDK
{
    public class PartyConstants
    {
        public const int c_maxNetworkConfigurationMaxDeviceCount = 32;

        public const int c_maxNetworkConfigurationMaxEndpointsPerDeviceCount = 32;

        public const int c_maxLocalUsersPerDeviceCount = 8;

        public const int c_opaqueConnectionInformationByteCount = 300;

        public const int c_maxInvitationIdentifierStringLength = 127;

        public const int c_maxInvitationEntityIdCount = 1024;

        public const int c_maxEntityIdStringLength = 20;

        public const int c_networkIdentifierStringLength = 36;

        public const int c_maxRegionNameStringLength = 19;

        public const int c_maxSerializedNetworkDescriptorStringLength = 448;

        public const int c_maxAudioDeviceIdentifierStringLength = 999;

        public const int c_maxLanguageCodeStringLength = 84;

        public const int c_maxChatTextMessageStringLength = 1023;

        public const int c_maxChatTranscriptionMessageStringLength = 1023;

        public const int c_maxTextToSpeechProfileIdentifierStringLength = 255;

        public const int c_maxTextToSpeechProfileNameStringLength = 127;

        public const int c_maxTextToSpeechInputStringLength = 1023;

        public const ulong c_anyProcessor = ulong.MaxValue;

        public const short c_minSendMessageQueuingPriority = -5;

        public const short c_chatSendMessageQueuingPriority = -3;

        public const short c_defaultSendMessageQueuingPriority = 0;

        public const short c_maxSendMessageQueuingPriority = 5;
    }
}