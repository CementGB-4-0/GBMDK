namespace PartyCSharpSDK
{
    public class PARTY_AUDIO_MANIPULATION_SOURCE_STREAM_CONFIGURATION
    {
        internal PARTY_AUDIO_MANIPULATION_SOURCE_STREAM_CONFIGURATION(
            Interop.PARTY_AUDIO_MANIPULATION_SOURCE_STREAM_CONFIGURATION interopStruct)
        {
        }

        public PARTY_AUDIO_FORMAT Format { get; }

        public uint MaxTotalAudioBufferSizeInMilliseconds { get; }
    }
}