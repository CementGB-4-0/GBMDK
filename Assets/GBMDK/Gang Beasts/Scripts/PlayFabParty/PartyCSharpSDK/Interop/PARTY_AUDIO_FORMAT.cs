namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_AUDIO_FORMAT
    {
        internal readonly uint samplesPerSecond;

        internal readonly uint channelMask;

        internal readonly ushort channelCount;

        internal readonly ushort bitsPerSample;

        internal readonly PARTY_AUDIO_SAMPLE_TYPE sampleType;

        internal readonly byte interleaved;

        internal PARTY_AUDIO_FORMAT(PartyCSharpSDK.PARTY_AUDIO_FORMAT publicObject)
        {
            samplesPerSecond = 0u;
            channelMask = 0u;
            channelCount = 0;
            bitsPerSample = 0;
            sampleType = default(PARTY_AUDIO_SAMPLE_TYPE);
            interleaved = 0;
        }
    }
}