namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_AUDIO_MANIPULATION_SINK_STREAM_CONFIGURATION
    {
        internal readonly PARTY_AUDIO_FORMAT format;

        internal PARTY_AUDIO_MANIPULATION_SINK_STREAM_CONFIGURATION(
            PartyCSharpSDK.PARTY_AUDIO_MANIPULATION_SINK_STREAM_CONFIGURATION publicObject)
        {
            format = default(PARTY_AUDIO_FORMAT);
        }
    }
}